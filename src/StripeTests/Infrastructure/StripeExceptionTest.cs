namespace StripeTests
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeExceptionTest : BaseStripeTest
    {
        public StripeExceptionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public async Task SetsStripeResponse()
        {
            // This test assumes that `POST /v1/payment_intents` has at least one required param,
            // and so will throw an exception if we provide zero params.
            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
            {
                await new PaymentIntentService(this.StripeClient)
                    .CreateAsync(new PaymentIntentCreateOptions());
            });

            Assert.NotNull(exception);
            Assert.NotNull(exception.StripeError);
            Assert.NotNull(exception.StripeError.StripeResponse);
        }

        [Fact]
        public void DeserializesNetworkAdviceCode()
        {
            var json = "{\"type\": \"card_error\", \"network_advice_code\": \"02\"}";
            var error = JsonConvert.DeserializeObject<StripeError>(json);
            Assert.Equal("02", error.NetworkAdviceCode);
        }

        [Fact]
        public void DeserializesPaymentIntent()
        {
            var json = "{\"type\": \"card_error\", \"payment_intent\": {\"id\": \"pi_123\", \"object\": \"payment_intent\", \"amount\": 1000}}";
            var error = JsonConvert.DeserializeObject<StripeError>(json);
            Assert.NotNull(error.PaymentIntent);
            Assert.Equal("pi_123", error.PaymentIntent.Id);
            Assert.Equal(1000, error.PaymentIntent.Amount);
        }
    }
}
