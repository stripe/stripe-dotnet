namespace StripeTests
{
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class ApiRequestorAdapterTest : BaseStripeTest
    {
        public ApiRequestorAdapterTest()
        {
        }

        [Fact]
        public async Task RequestAsync_BaseAddressApi()
        {
            var httpClient = new DummyHttpClient();
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            httpClient.Response = response;

            var stripeClient = new StripeClient(
                new StripeClientOptions
                {
                    ApiKey = "sk_test_123",
                    HttpClient = httpClient,
                });

            var underTest = new ApiRequestorAdapter(stripeClient);
            await underTest.RequestAsync<Charge>(
                BaseAddress.Api,
                HttpMethod.Post,
                "/v1/charges",
                new BaseOptions(),
                null);

            Assert.Equal("https://api.stripe.com/v1/charges", httpClient.LastRequest.Uri.ToString());
        }

        [Fact]
        public async Task RequestAsync_BaseAddressConnect()
        {
            var httpClient = new DummyHttpClient();
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            httpClient.Response = response;

            var stripeClient = new StripeClient(
                new StripeClientOptions
                {
                    ApiKey = "sk_test_123",
                    HttpClient = httpClient,
                });

            var underTest = new ApiRequestorAdapter(stripeClient);
            await underTest.RequestAsync<Charge>(
                BaseAddress.Connect,
                HttpMethod.Post,
                "/v1/charges",
                new BaseOptions(),
                null);

            Assert.Equal("https://connect.stripe.com/v1/charges", httpClient.LastRequest.Uri.ToString());
        }

        [Fact]
        public async Task RequestAsync_BaseAddressFiles()
        {
            var httpClient = new DummyHttpClient();
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            httpClient.Response = response;

            var stripeClient = new StripeClient(
                new StripeClientOptions
                {
                    ApiKey = "sk_test_123",
                    HttpClient = httpClient,
                });

            var underTest = new ApiRequestorAdapter(stripeClient);
            await underTest.RequestAsync<Charge>(
                BaseAddress.Files,
                HttpMethod.Post,
                "/v1/charges",
                new BaseOptions(),
                null);

            Assert.Equal("https://files.stripe.com/v1/charges", httpClient.LastRequest.Uri.ToString());
        }

        [Fact]
        public async Task RequestAsync_BaseAddressMeterEvents()
        {
            var httpClient = new DummyHttpClient();
            var response = new StripeResponse(HttpStatusCode.OK, null, "{\"id\": \"ch_123\"}");
            httpClient.Response = response;

            var stripeClient = new StripeClient(
                new StripeClientOptions
                {
                    ApiKey = "sk_test_123",
                    HttpClient = httpClient,
                });

            var underTest = new ApiRequestorAdapter(stripeClient);
            await underTest.RequestAsync<Charge>(
                BaseAddress.MeterEvents,
                HttpMethod.Post,
                "/v1/charges",
                new BaseOptions(),
                null);

            Assert.Equal("https://meter-events.stripe.com/v1/charges", httpClient.LastRequest.Uri.ToString());
        }
    }
}
