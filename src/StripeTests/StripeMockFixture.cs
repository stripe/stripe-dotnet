namespace StripeTests
{
    using System;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe;

    public class StripeMockFixture : IDisposable
    {
        /// <value>Minimum required version of stripe-mock.</value>
        private const string MockMinimumVersion = "0.119.0";

        private readonly string port;

        public StripeMockFixture()
        {
            if (StripeMockHandler.StartStripeMock())
            {
                this.port = StripeMockHandler.Port.ToString();
            }
            else
            {
                this.port = Environment.GetEnvironmentVariable("STRIPE_MOCK_PORT") ?? "12111";
            }

            this.EnsureStripeMockMinimumVersion();
        }

        public void Dispose()
        {
            StripeMockHandler.StopStripeMock();
        }

        /// <summary>
        /// Creates and returns a new instance of <see cref="ApiRequestor"/> suitable for use with
        /// stripe-mock.
        /// </summary>
        /// <param name="innerHandler">
        /// The <see cref="HttpClient"/> client to use. If <c>null</c>, an HTTP client will be
        /// created with default parameters.
        /// </param>
        /// <returns>The new <see cref="ApiRequestor"/> instance.</returns>
        internal ApiRequestor BuildApiRequestor(HttpClientHandler innerHandler = null)
        {
            return new LiveApiRequestor(
                "sk_test_123",
                "ca_123",
                httpClient: new SystemNetHttpClient(new ForwardingHttpClient(innerHandler, this.port)));
        }

        /// <summary>
        /// Gets fixture data with expansions specified. Expansions are specified the same way as
        /// they are in the normal API like <c>customer</c> or <c>data.customer</c>.
        /// Use the special <c>*</c> character to specify that all fields should be
        /// expanded.
        /// </summary>
        /// <param name="path">API path to use to get a fixture for stripe-mock.</param>
        /// <param name="expansions">Set of expansions that should be applied.</param>
        /// <returns>Fixture data encoded as JSON.</returns>
        public string GetFixture(string path, string[] expansions = null)
        {
            string url = $"http://localhost:{this.port}{path}";

            if (expansions != null)
            {
                string query = string.Join("&", expansions.Select(x => $"expand[]={x}").ToArray());
                url += $"?{query}";
            }

            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                client.DefaultRequestHeaders.Authorization
                    = new System.Net.Http.Headers.AuthenticationHeaderValue(
                        "Bearer",
                        "sk_test_123");

                HttpResponseMessage response;

                try
                {
                    response = client.GetAsync(url).Result;
                }
                catch (Exception)
                {
                    throw new StripeTestException(
                        $"Couldn't reach stripe-mock at `localhost:{this.port}`. "
                        + "Is it running? Please see README for setup instructions.");
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new StripeTestException(
                        $"stripe-mock returned status code: {response.StatusCode}.");
                }

                return response.Content.ReadAsStringAsync().Result;
            }
        }

        /// <summary>
        /// Compares two version strings.
        /// </summary>
        /// <param name="a">A version string (e.g. "1.2.3").</param>
        /// <param name="b">Another version string.</param>
        /// <returns>-1 if a &gt; b, 1 if a &lt; b, 0 if a == b.</returns>
        private static int CompareVersions(string a, string b)
        {
            var version1 = new Version(a);
            var version2 = new Version(b);
            return version2.CompareTo(version1);
        }

        private void EnsureStripeMockMinimumVersion()
        {
            string url = $"http://localhost:{this.port}";

            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                HttpResponseMessage response;

                try
                {
                    response = client.GetAsync(url).Result;
                }
                catch (Exception)
                {
                    throw new StripeTestException(
                        $"Couldn't reach stripe-mock at `localhost:{this.port}`. "
                        + "Is it running? Please see README for setup instructions.");
                }

                string version = response.Headers.GetValues("Stripe-Mock-Version").FirstOrDefault();

                if (!version.Equals("master") &&
                    (CompareVersions(version, MockMinimumVersion) > 0))
                {
                    throw new StripeTestException(
                        $"Your version of stripe-mock ({version}) is too old. The minimum "
                        + $"version to run this test suite is {MockMinimumVersion}. Please see its "
                        + "repository for upgrade instructions.");
                }
            }
        }

        private class ForwardingHttpClient : HttpClient
        {
            private readonly string port;

            public ForwardingHttpClient(HttpClientHandler innerHandler, string port)
                : base(innerHandler ?? new HttpClientHandler())
            {
                this.port = port;
            }

            public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                request.Properties.Add("OriginalHost", request.RequestUri.Host);
                request.RequestUri = new Uri($"http://localhost:{this.port}{request.RequestUri!.PathAndQuery}");
                return base.SendAsync(request, cancellationToken);
            }
        }
    }
}
