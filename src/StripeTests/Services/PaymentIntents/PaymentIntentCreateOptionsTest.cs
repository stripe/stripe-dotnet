namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class PaymentIntentCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeObjectProperly()
        {
            var options_bool = new PaymentIntentCreateOptions
            {
                OffSession = true,
            };

            Assert.Equal("off_session=True", FormEncoder.CreateQueryString(options_bool));
        }
    }
}
