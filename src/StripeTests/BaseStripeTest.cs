namespace StripeTests
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using System.Text;
    using System.Threading;

    using Moq;
    using Moq.Protected;
    using Stripe;

    public class BaseStripeTest
    {
        /// <value>Minimum required version of stripe-mock</value>
        /// <remarks>
        /// If you bump this, don't forget to bump `STRIPE_MOCK_VERSION` in appveyor.yml as well.
        /// </remarks>
        private const string MockMinimumVersion = "0.33.0";

        private static Mock<HttpClientHandler> mockHandler = null;

        private static string port;

        // Lazy initializer to ensure that initialization is run only once even when running tests
        // in parallel.
        private static Lazy<object> initializer = new Lazy<object>(InitStripeMock);

        public BaseStripeTest()
        {
            // This triggers the lazy initialization. We don't actually care about the value of
            // initialized (it will be null anyway), but simply writing `initializer.Value` is not
            // a valid statement in C#.
            var initialized = initializer.Value;

            // Reset the mock before each test
            mockHandler.Invocations.Clear();
        }

        /// <summary>
        /// Gets fixture data from stripe-mock for a resource expected to be at the given API path.
        /// stripe-mock ignores whether IDs are actually valid, so it's only important to make sure
        /// that the route exists, rather than the actual resource. It's common to use a symbolic
        /// ID stand-in like <code>ch_123</code>
        /// </summary>
        /// <param name="path">API path to use to get a fixture for stripe-mock</param>
        /// <returns>Fixture data encoded as JSON</returns>
        protected static string GetFixture(string path)
        {
            return GetFixture(path, null);
        }

        /// <summary>
        /// Gets fixture data with expansions specified. Expansions are specified the same way as
        /// they are in the normal API like <code>customer</code> or <code>data.customer</code>.
        /// Use the special <code>*</code> character to specify that all fields should be
        /// expanded.
        /// </summary>
        /// <param name="path">API path to use to get a fixture for stripe-mock</param>
        /// <param name="expansions">Set of expansions that should be applied</param>
        /// <returns>Fixture data encoded as JSON</returns>
        protected static string GetFixture(string path, string[] expansions)
        {
            string url = $"http://localhost:{port}{path}";

            if (expansions != null)
            {
                string query = string.Join("&", expansions.Select(x => $"expand[]={x}").ToArray());
                url += $"?{query}";
            }

            using (HttpClient client = new HttpClient())
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
                    throw new Exception(
                        $"Couldn't reach stripe-mock at `localhost:{port}`. "
                        + "Is it running? Please see README for setup instructions.");
                }

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new Exception(
                        $"stripe-mock returned status code: {response.StatusCode}.");
                }

                return response.Content.ReadAsStringAsync().Result;
            }
        }

        /// <summary>
        /// Gets a resource file and returns its contents in a string.
        /// </summary>
        /// <param name="path">Path to the resource file</param>
        /// <returns>File contents</returns>
        protected static string GetResourceAsString(string path)
        {
            var fullpath = "StripeTests.Resources." + path;
            var json = new StreamReader(
                typeof(BaseStripeTest).GetTypeInfo().Assembly.GetManifestResourceStream(fullpath),
                Encoding.UTF8).ReadToEnd();

            return json;
        }

        protected void AssertRequest(HttpMethod method, string path)
        {
            mockHandler.Protected().Verify(
                "SendAsync",
                Times.Once(),
                ItExpr.Is<HttpRequestMessage>(m =>
                    m.Method == method &&
                    m.RequestUri.AbsolutePath == path),
                ItExpr.IsAny<CancellationToken>());
        }

        /// <summary>
        /// Checks that stripe-mock is running and that it's a recent enough version.
        /// </summary>
        private static object InitStripeMock()
        {
            port = Environment.GetEnvironmentVariable("STRIPE_MOCK_PORT") ?? "12111";
            string url = $"http://localhost:{port}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response;

                try
                {
                    response = client.GetAsync(url).Result;
                }
                catch (Exception)
                {
                    throw new Exception(
                        $"Couldn't reach stripe-mock at `localhost:{port}`. "
                        + "Is it running? Please see README for setup instructions.");
                }

                string version = response.Headers.GetValues("Stripe-Mock-Version").FirstOrDefault();

                if (!version.Equals("master") &&
                    (CompareVersions(version, MockMinimumVersion) > 0))
                {
                    throw new Exception(
                        $"Your version of stripe-mock ({version}) is too old. The minimum "
                        + $"version to run this test suite is {MockMinimumVersion}. Please see its "
                        + "repository for upgrade instructions.");
                }
            }

            StripeConfiguration.SetApiBase($"http://localhost:{port}/v1");
            StripeConfiguration.SetFilesBase($"http://localhost:{port}/v1");
            StripeConfiguration.SetApiKey("sk_test_123");

            mockHandler = new Mock<HttpClientHandler>()
            {
                CallBase = true
            };
            StripeConfiguration.HttpMessageHandler = mockHandler.Object;

            return null;
        }

        /// <summary>
        /// Compares two version strings.
        /// </summary>
        /// <param name="a">A version string (e.g. "1.2.3").</param>
        /// <param name="b">Another version string.</param>
        /// <returns>-1 if a > b, 1 if a < b, 0 if a == b</returns>
        private static int CompareVersions(string a, string b)
        {
            var version1 = new Version(a);
            var version2 = new Version(b);
            return version2.CompareTo(version1);
        }
    }
}
