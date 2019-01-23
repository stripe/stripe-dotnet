namespace StripeTests
{
    using System.IO;
    using System.Net;
    using System.Net.Http;
    using System.Reflection;
    using System.Text;
    using Xunit;

    [Collection("stripe-mock tests")]
    public class BaseStripeTest
    {
        public BaseStripeTest()
            : this(null, null)
        {
        }

        public BaseStripeTest(StripeMockFixture stripeMockFixture)
            : this(stripeMockFixture, null)
        {
        }

        public BaseStripeTest(MockHttpClientFixture mockHttpClientFixture)
            : this(null, mockHttpClientFixture)
        {
        }

        public BaseStripeTest(StripeMockFixture stripeMockFixture, MockHttpClientFixture mockHttpClientFixture)
        {
            this.StripeMockFixture = stripeMockFixture;
            this.MockHttpClientFixture = mockHttpClientFixture;

            if (this.MockHttpClientFixture != null)
            {
                // Reset the mock before each test
                this.MockHttpClientFixture.Reset();
            }
        }

        protected MockHttpClientFixture MockHttpClientFixture { get; }

        protected StripeMockFixture StripeMockFixture { get; }

        /// <summary>
        /// Gets a resource file and returns its contents in a string.
        /// </summary>
        /// <param name="path">Path to the resource file</param>
        /// <returns>File contents</returns>
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
        /// <param name="path">API path to use to get a fixture for stripe-mock</param>
        /// <param name="expansions">Set of expansions that should be applied</param>
        /// <returns>Fixture data encoded as JSON</returns>
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
