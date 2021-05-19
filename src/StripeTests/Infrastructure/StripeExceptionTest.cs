namespace StripeTests
{
    using System.Threading.Tasks;
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
    }
}
