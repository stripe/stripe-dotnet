namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Standard client to make requests to Stripe's API, using
    /// <see cref="System.Net.Http.HttpClient"/> to send HTTP requests. It can gather telemetry
    /// about request latency (via <see cref="RequestTelemetry"/>) and automatically retry failed
    /// requests when it's safe to do so.
    /// </summary>
    public class SystemNetHttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient httpClient;

        private readonly int maxNetworkRetries;

        private readonly AppInfo appInfo;

        private readonly bool enableTelemetry;

        private readonly RequestTelemetry requestTelemetry = new RequestTelemetry();

        private readonly object randLock = new object();

        private readonly Random rand = new Random();

        private string stripeClientUserAgentString;

        private string userAgentString;

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemNetHttpClient"/> class.
        /// </summary>
        /// <param name="httpClient">
        /// The <see cref="System.Net.Http.HttpClient"/> client to use. If <c>null</c>, an HTTP
        /// client will be created with default parameters.
        /// </param>
        /// <param name="maxNetworkRetries">
        /// The maximum number of times the client will retry requests that fail due to an
        /// intermittent problem
        /// </param>
        /// <param name="appInfo">
        /// Information about the "app" which this integration belongs to. This should be reserved
        /// for plugins that wish to identify themselves with Stripe.
        /// </param>
        /// <param name="enableTelemetry">
        /// Whether to enable request latency telemetry or not.
        /// </param>
        public SystemNetHttpClient(
            System.Net.Http.HttpClient httpClient = null,
            int maxNetworkRetries = 0,
            AppInfo appInfo = null,
            bool enableTelemetry = true)
        {
#if NET45
            // With .NET Framework 4.5, it's necessary to manually enable support for TLS 1.2.
            ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol |
                SecurityProtocolType.Tls12;
#endif

            this.httpClient = httpClient ?? BuildDefaultSystemNetHttpClient();
            this.maxNetworkRetries = maxNetworkRetries;
            this.appInfo = appInfo;
            this.enableTelemetry = enableTelemetry;

            this.stripeClientUserAgentString = this.BuildStripeClientUserAgentString();
            this.userAgentString = this.BuildUserAgentString();
        }

        /// <summary>Default timespan before the request times out.</summary>
        public static TimeSpan DefaultHttpTimeout => TimeSpan.FromSeconds(80);

        /// <summary>
        /// Maximum sleep time between tries to send HTTP requests after network failure.
        /// </summary>
        public static TimeSpan MaxNetworkRetriesDelay => TimeSpan.FromSeconds(5);

        /// <summary>
        /// Minimum sleep time between tries to send HTTP requests after network failure.
        /// </summary>
        public static TimeSpan MinNetworkRetriesDelay => TimeSpan.FromMilliseconds(500);

        /// <summary>
        /// Gets or sets a value indicating whether the client should sleep between automatic
        /// request retries.
        /// </summary>
        /// <remarks>This is an internal property meant to be used in tests only.</remarks>
        internal bool NetworkRetriesSleep { get; set; } = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="System.Net.Http.HttpClient"/> class
        /// with default parameters.
        /// </summary>
        /// <returns>The new instance of the <see cref="System.Net.Http.HttpClient"/> class.</returns>
        public static System.Net.Http.HttpClient BuildDefaultSystemNetHttpClient()
        {
            // We set the User-Agent and X-Stripe-Client-User-Agent headers in each request
            // message rather than through the client's `DefaultRequestHeaders` because we
            // want these headers to be present even when a custom HTTP client is used.
            return new System.Net.Http.HttpClient
            {
                Timeout = DefaultHttpTimeout,
            };
        }

        /// <summary>Sends a request to Stripe's API as an asynchronous operation.</summary>
        /// <param name="request">The parameters of the request to send.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public async Task<StripeResponse> MakeRequestAsync(
            StripeRequest request,
            CancellationToken cancellationToken = default(CancellationToken))
        {
            TimeSpan duration;
            Exception requestException = null;
            HttpResponseMessage response = null;
            int retry = 0;

            if (this.enableTelemetry)
            {
                this.requestTelemetry.MaybeAddTelemetryHeader(request.StripeHeaders);
            }

            while (true)
            {
                requestException = null;

                var httpRequest = this.BuildRequestMessage(request);

                var stopwatch = Stopwatch.StartNew();

                try
                {
                    response = await this.httpClient.SendAsync(httpRequest, cancellationToken)
                        .ConfigureAwait(false);
                }
                catch (HttpRequestException exception)
                {
                    requestException = exception;
                }
                catch (OperationCanceledException exception)
                    when (!cancellationToken.IsCancellationRequested)
                {
                    requestException = exception;
                }

                stopwatch.Stop();

                duration = stopwatch.Elapsed;

                if (!this.ShouldRetry(
                    retry,
                    requestException != null,
                    response?.StatusCode,
                    response?.Headers))
                {
                    break;
                }

                retry += 1;
                await Task.Delay(this.SleepTime(retry)).ConfigureAwait(false);
            }

            if (requestException != null)
            {
                throw requestException;
            }

            if (this.enableTelemetry)
            {
                this.requestTelemetry.MaybeEnqueueMetrics(response, duration);
            }

            var reader = new StreamReader(
                await response.Content.ReadAsStreamAsync().ConfigureAwait(false));

            return new StripeResponse(
                response.StatusCode,
                response.Headers,
                await reader.ReadToEndAsync().ConfigureAwait(false))
            {
                NumRetries = retry,
            };
        }

        private string BuildStripeClientUserAgentString()
        {
            var values = new Dictionary<string, object>
            {
                { "bindings_version", StripeConfiguration.StripeNetVersion },
                { "lang", ".net" },
                { "publisher", "stripe" },
                { "lang_version", RuntimeInformation.GetLanguageVersion() },
                { "os_version", RuntimeInformation.GetOSVersion() },
            };

#if NET45
            string monoVersion = RuntimeInformation.GetMonoVersion();
            if (!string.IsNullOrEmpty(monoVersion))
            {
                values.Add("mono_version", monoVersion);
            }
#endif

            if (this.appInfo != null)
            {
                values.Add("application", this.appInfo);
            }

            return JsonConvert.SerializeObject(values, Formatting.None);
        }

        private string BuildUserAgentString()
        {
            var userAgent = $"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}";

            if (this.appInfo != null)
            {
                userAgent += " " + this.appInfo.FormatUserAgent();
            }

            return userAgent;
        }

        private bool ShouldRetry(
            int numRetries,
            bool error,
            HttpStatusCode? statusCode,
            HttpHeaders headers)
        {
            // Do not retry if we are out of retries.
            if (numRetries >= this.maxNetworkRetries)
            {
                return false;
            }

            // Retry on connection error.
            if (error == true)
            {
                return true;
            }

            // The API may ask us not to retry (eg; if doing so would be a no-op)
            // or advise us to retry (eg; in cases of lock timeouts); we defer to that.
            if (headers != null && headers.Contains("Stripe-Should-Retry"))
            {
                var value = headers.GetValues("Stripe-Should-Retry").First();

                switch (value)
                {
                    case "true":
                        return true;
                    case "false":
                        return false;
                }
            }

            // Retry on conflict errors.
            if (statusCode == HttpStatusCode.Conflict)
            {
                return true;
            }

            // Retry on 500, 503, and other internal errors.
            //
            // Note that we expect the Stripe-Should-Retry header to be false
            // in most cases when a 500 is returned, since our idempotency framework
            // would typically replay it anyway.
            if (statusCode.HasValue && ((int)statusCode.Value >= 500))
            {
                return true;
            }

            return false;
        }

        private System.Net.Http.HttpRequestMessage BuildRequestMessage(StripeRequest request)
        {
            var requestMessage = new System.Net.Http.HttpRequestMessage(request.Method, request.Uri);

            // Standard headers
            requestMessage.Headers.TryAddWithoutValidation("User-Agent", this.userAgentString);
            requestMessage.Headers.Authorization = request.AuthorizationHeader;

            // Custom headers
            requestMessage.Headers.Add("X-Stripe-Client-User-Agent", this.stripeClientUserAgentString);
            foreach (var header in request.StripeHeaders)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            // Request body
            requestMessage.Content = request.Content;

            return requestMessage;
        }

        private TimeSpan SleepTime(int numRetries)
        {
            // We disable sleeping in some cases for tests.
            if (!this.NetworkRetriesSleep)
            {
                return TimeSpan.Zero;
            }

            // Apply exponential backoff with MinNetworkRetriesDelay on the number of numRetries
            // so far as inputs.
            var delay = TimeSpan.FromTicks((long)(MinNetworkRetriesDelay.Ticks
                * Math.Pow(2, numRetries - 1)));

            // Do not allow the number to exceed MaxNetworkRetriesDelay
            if (delay > MaxNetworkRetriesDelay)
            {
                delay = MaxNetworkRetriesDelay;
            }

            // Apply some jitter by randomizing the value in the range of 75%-100%.
            var jitter = 1.0;
            lock (this.randLock)
            {
                jitter = (3.0 + this.rand.NextDouble()) / 4.0;
            }

            delay = TimeSpan.FromTicks((long)(delay.Ticks * jitter));

            // But never sleep less than the base sleep seconds.
            if (delay < MinNetworkRetriesDelay)
            {
                delay = MinNetworkRetriesDelay;
            }

            return delay;
        }
    }
}
