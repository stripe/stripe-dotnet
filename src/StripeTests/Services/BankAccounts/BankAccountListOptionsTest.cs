namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class BankAccountListOptionsTest : BaseStripeTest
    {
        private readonly BankAccountService service;

        public BankAccountListOptionsTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new BankAccountService();
        }

        [Fact]
        public void SerializeObjectProperly()
        {
            var options = new BankAccountListOptions();

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?object=bank_account", url);
        }
    }
}
