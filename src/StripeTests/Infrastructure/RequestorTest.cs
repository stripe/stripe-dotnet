namespace StripeTests
{
    using System.Linq;
    using System.Net.Http;
    using Newtonsoft.Json.Linq;
    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class RequestorTest : BaseStripeTest
    {
        [Fact]
        public void SetsHeaders()
        {
            RequestOptions options = new RequestOptions
            {
                ApiKey = "sk_key",
                StripeConnectAccountId = "acct_123",
                IdempotencyKey = "123",
            };
            var request = Requestor.GetRequestMessage(HttpMethod.Get, string.Empty, null, options);
            Assert.NotNull(request);
            Assert.Equal($"Bearer {options.ApiKey}", request.Headers.GetValues("Authorization").FirstOrDefault());
            Assert.Equal(options.IdempotencyKey, request.Headers.GetValues("Idempotency-Key").FirstOrDefault());
            Assert.Equal(options.StripeConnectAccountId, request.Headers.GetValues("Stripe-Account").FirstOrDefault());
            Assert.Equal(StripeConfiguration.ApiVersion, request.Headers.GetValues("Stripe-Version").FirstOrDefault());

            Assert.Equal(
                $"Stripe/v1 .NetBindings/{StripeConfiguration.StripeNetVersion}",
                request.Headers.UserAgent.ToString());

            var json = request.Headers.GetValues("X-Stripe-Client-User-Agent").FirstOrDefault();
            Assert.NotNull(json);
            var data = JObject.Parse(json);
            Assert.Equal(StripeConfiguration.StripeNetVersion, data["bindings_version"]);
            Assert.Equal(".net", data["lang"]);
            Assert.Equal("stripe", data["publisher"]);
            Assert.NotNull(data["lang_version"]);
            Assert.NotNull(data["os_version"]);
        }
    }
}
