namespace Stripe
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Standard client to make requests to Stripe's API, using
    /// <see cref="System.Net.Http.HttpClient"/> to send HTTP requests.
    /// </summary>
    public class SystemNetHttpClient : IHttpClient
    {
        private static readonly string UserAgentString
            = $"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}";

        private static readonly string StripeClientUserAgentString
            = BuildStripeClientUserAgentString();

        private readonly System.Net.Http.HttpClient httpClient;

        private readonly RequestTelemetry requestTelemetry = new RequestTelemetry();

        /// <summary>
        /// Initializes a new instance of the <see cref="SystemNetHttpClient"/> class.
        /// </summary>
        /// <param name="httpClient">
        /// The <see cref="System.Net.Http.HttpClient"/> client to use. If <c>null</c>, an HTTP
        /// client will be created with default parameters.
        /// </param>
        public SystemNetHttpClient(System.Net.Http.HttpClient httpClient = null)
        {
            this.httpClient = httpClient ?? BuildDefaultSystemNetHttpClient();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="System.Net.Http.HttpClient"/> class
        /// with default parameters.
        /// </summary>
        /// <returns>The new instance of the <see cref="System.Net.Http.HttpClient"/> class.</returns>
        public static System.Net.Http.HttpClient BuildDefaultSystemNetHttpClient()
        {
            // We set the User-Agent and X-Stripe-Client-User-Agent headers in each request
            // message rather than through the client's <c>DefaultRequestHeaders</c> because we
            // want these headers to be present even when a custom HTTP client is used.
            return new System.Net.Http.HttpClient()
            {
                Timeout = StripeConfiguration.DefaultHttpTimeout,
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
            var httpRequest = BuildRequestMessage(request);

            this.requestTelemetry.MaybeAddTelemetryHeader(httpRequest.Headers);

            var stopwatch = Stopwatch.StartNew();
            var response = await this.httpClient.SendAsync(httpRequest, cancellationToken)
                .ConfigureAwait(false);
            stopwatch.Stop();

            this.requestTelemetry.MaybeEnqueueMetrics(response, stopwatch.ElapsedMilliseconds);

            var reader = new StreamReader(
                await response.Content.ReadAsStreamAsync().ConfigureAwait(false));

            return new StripeResponse(
                response.StatusCode,
                response.Headers,
                await reader.ReadToEndAsync().ConfigureAwait(false));
        }

        private static System.Net.Http.HttpRequestMessage BuildRequestMessage(StripeRequest request)
        {
            var requestMessage = new System.Net.Http.HttpRequestMessage(request.Method, request.Uri);

            // Standard headers
            requestMessage.Headers.UserAgent.ParseAdd(UserAgentString);
            requestMessage.Headers.Authorization = request.AuthorizationHeader;

            // Custom headers
            requestMessage.Headers.Add("X-Stripe-Client-User-Agent", StripeClientUserAgentString);
            foreach (var header in request.StripeHeaders)
            {
                requestMessage.Headers.Add(header.Key, header.Value);
            }

            // Request body
            requestMessage.Content = request.Content;

            return requestMessage;
        }

        private static string BuildStripeClientUserAgentString()
        {
            var values = new Dictionary<string, string>
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

            return JsonConvert.SerializeObject(values, Formatting.None);
        }
    }
}
