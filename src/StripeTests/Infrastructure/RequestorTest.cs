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
            var request = Requestor.GetRequestMessage("http://localhost", HttpMethod.Get, options);
            Assert.NotNull(request);
            Assert.Equal($"Bearer {options.ApiKey}", request.Headers.GetValues("Authorization").FirstOrDefault());
            Assert.Equal(options.IdempotencyKey, request.Headers.GetValues("Idempotency-Key").FirstOrDefault());
            Assert.Equal(options.StripeConnectAccountId, request.Headers.GetValues("Stripe-Account").FirstOrDefault());
            Assert.Equal(StripeConfiguration.ApiVersion, request.Headers.GetValues("Stripe-Version").FirstOrDefault());
        }
    }
}
