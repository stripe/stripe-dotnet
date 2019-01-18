namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure.Extensions;
    using Xunit;

    public class BankAccountListOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeObjectProperly()
        {
            var options = new BankAccountListOptions();

            Assert.Equal("object=bank_account", options.ToQueryString());
        }
    }
}
