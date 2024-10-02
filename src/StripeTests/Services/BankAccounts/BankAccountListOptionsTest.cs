namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class BankAccountListOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeObjectProperly()
        {
            var options = new BankAccountListOptions();

            Assert.Equal("object=bank_account", FormEncoder.CreateQueryString(options));
        }
    }
}
