namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class PaymentIntentConfirmOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeObjectProperly()
        {
            var options_bool = new PaymentIntentConfirmOptions
            {
                OffSession = true,
            };

            Assert.Equal("off_session=true", ContentEncoder.CreateQueryString(options_bool));
        }
    }
}
