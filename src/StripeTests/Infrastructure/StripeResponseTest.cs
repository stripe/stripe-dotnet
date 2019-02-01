namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class StripeResponseTest : BaseStripeTest
    {
        private readonly StripeList<Charge> charges;

        public StripeResponseTest()
        {
            this.charges = new ChargeService().List();
        }

        [Fact]
        public void Initializes()
        {
            Assert.NotNull(this.charges);
            Assert.NotNull(this.charges.StripeResponse);
            Assert.NotNull(this.charges.StripeResponse.RequestId);
            Assert.NotNull(this.charges.StripeResponse.ResponseJson);
            Assert.True(this.charges.StripeResponse.RequestDate.Year > 0);
        }
    }
}
