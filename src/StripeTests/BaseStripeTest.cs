namespace StripeTests
{
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using System.Text;
    using Stripe;
    using Xunit;

    [Collection("stripe-mock tests")]
    public class BaseStripeTest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStripeTest"/> class with no fixtures.
        /// </summary>
        public BaseStripeTest()
            : this(null, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStripeTest"/> class with the
        /// <see cref="StripeMockFixture"/> fixture. Use this constructor for tests that need to
        /// send requests to stripe-mock, but don't need mocking capabilities (i.e. don't need to
        /// assert or stub HTTP requests).
        /// </summary>
        /// <param name="stripeMockFixture">
        /// The <see cref="StripeMockFixture"/> fixture.
        /// </param>
        public BaseStripeTest(StripeMockFixture stripeMockFixture)
            : this(stripeMockFixture, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStripeTest"/> class with the
        /// <see cref="MockHttpClientFixture"/> fixture. Use this constructor for tests that need
        /// mocking capabilities (i.e. need to assert or stub HTTP requests) but don't need to send
        /// requests to stripe-mock.
        /// </summary>
        /// <param name="mockHttpClientFixture">
        /// The <see cref="MockHttpClientFixture"/> fixture.
        /// </param>
        public BaseStripeTest(MockHttpClientFixture mockHttpClientFixture)
            : this(null, mockHttpClientFixture)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseStripeTest"/> class with both the
        /// <see cref="StripeMockFixture"/> and the <see cref="MockHttpClientFixture"/> fixtures.
        /// Use this constructor for tests that need to send requests to stripe-mock and also need
        /// mocking capabilities (i.e. need to assert or stub HTTP requests).
        /// </summary>
        /// <param name="stripeMockFixture">
        /// The <see cref="StripeMockFixture"/> fixture.
        /// </param>
        /// <param name="mockHttpClientFixture">
        /// The <see cref="MockHttpClientFixture"/> fixture.
        /// </param>
        public BaseStripeTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
        {
            this.StripeMockFixture = stripeMockFixture;
            this.MockHttpClientFixture = mockHttpClientFixture;

            if ((this.StripeMockFixture != null) && (this.MockHttpClientFixture != null))
            {
                // Set up StripeClient to use stripe-mock with the mock HTTP client
                var httpClient = new SystemNetHttpClient(
                    new HttpClient(this.MockHttpClientFixture.MockHandler.Object));
                this.StripeClient = this.StripeMockFixture.BuildStripeClient(
                    httpClient: httpClient);

                // Reset the mock before each test
                this.MockHttpClientFixture.Reset();
            }
            else if (this.StripeMockFixture != null)
            {
                // Set up StripeClient to use stripe-mock
                this.StripeClient = this.StripeMockFixture.BuildStripeClient();
            }
            else if (this.MockHttpClientFixture != null)
            {
                // Set up StripeClient with the mock HTTP client
                var httpClient = new SystemNetHttpClient(
                    new HttpClient(this.MockHttpClientFixture.MockHandler.Object));
                this.StripeClient = new StripeClient(
                    "sk_test_123",
                    httpClient: httpClient);

                // Reset the mock before each test
                this.MockHttpClientFixture.Reset();
            }
            else
            {
                // Use the default StripeClient
                this.StripeClient = new StripeClient("sk_test_123");
            }
        }

        protected IStripeClient StripeClient { get; }

        protected MockHttpClientFixture MockHttpClientFixture { get; }

        protected StripeMockFixture StripeMockFixture { get; }

        /// <summary>
        /// Gets a resource file and returns its contents in a string.
        /// </summary>
        /// <param name="path">Path to the resource file.</param>
        /// <returns>The file contents.</returns>
        protected static string GetResourceAsString(string path)
        {
            var fullpath = "StripeTests.Resources." + path;
            var contents = new StreamReader(
                typeof(BaseStripeTest).GetTypeInfo().Assembly.GetManifestResourceStream(fullpath),
                Encoding.UTF8).ReadToEnd();

            return contents;
        }

        /// <summary>
        /// Asserts that a single HTTP request was made with the specified method and path.
        /// </summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        protected void AssertRequest(HttpMethod method, string path)
        {
            if (this.MockHttpClientFixture == null)
            {
                throw new StripeTestException(
                    "AssertRequest called from a test class that doesn't have access to "
                    + "MockHttpClientFixture. Make sure that the constructor for "
                    + $"{this.GetType().Name} receives MockHttpClientFixture and calls the "
                    + "base constructor.");
            }

            this.MockHttpClientFixture.AssertRequest(method, path);
        }

        /// <summary>
        /// Stubs an HTTP request with the specified method and path to return the specified status
        /// code and response body.
        /// </summary>
        /// <param name="method">The HTTP method.</param>
        /// <param name="path">The HTTP path.</param>
        /// <param name="status">The status code to return.</param>
        /// <param name="response">The response body to return.</param>
        protected void StubRequest(HttpMethod method, string path, HttpStatusCode status, string response)
        {
            if (this.MockHttpClientFixture == null)
            {
                throw new StripeTestException(
                    "StubRequest called from a test class that doesn't have access to "
                    + "MockHttpClientFixture. Make sure that the constructor for "
                    + $"{this.GetType().Name} receives MockHttpClientFixture and calls the "
                    + "base constructor.");
            }

            this.MockHttpClientFixture.StubRequest(method, path, status, response);
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
        protected string GetFixture(string path, string[] expansions = null)
        {
            if (this.StripeMockFixture == null)
            {
                throw new StripeTestException(
                    "GetFixture called from a test class that doesn't have access to "
                    + "StripeMockFixture. Make sure that the constructor for "
                    + $"{this.GetType().Name} receives StripeMockFixture and calls the "
                    + "base constructor.");
            }

            return this.StripeMockFixture.GetFixture(path, expansions);
        }
    }
}
