namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class ClientTest : BaseStripeTest
    {
        public ClientTest()
        {
        }

        [Fact]
        public void SetsUserAgent()
        {
            var request = new HttpRequestMessage();
            Assert.NotNull(request);

            var client = new Client(request);
            client.ApplyClientData();
            client.ApplyUserAgent();

            var expectedUserAgent = $"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}";
            Assert.Equal(expectedUserAgent, request.Headers.UserAgent.ToString());
            Assert.NotNull(request.Headers.GetValues("X-Stripe-Client-User-Agent"));

            var userAgentJson = JToken.Parse(request.Headers.GetValues("X-Stripe-Client-User-Agent").FirstOrDefault());
            Assert.NotNull(userAgentJson);
            Assert.Equal(StripeConfiguration.StripeNetVersion, userAgentJson["bindings_version"]);
            Assert.Equal(".net", userAgentJson["lang"]);
            Assert.Equal("stripe", userAgentJson["publisher"]);
            Assert.NotNull(userAgentJson["lang_version"]);
            Assert.NotNull(userAgentJson["os_version"]);
        }
    }
}