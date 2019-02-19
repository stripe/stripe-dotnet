namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class AccountCreateOptionsTest : BaseStripeTest
    {
        private readonly AccountService service;

        public AccountCreateOptionsTest(MockHttpClientFixture mockHttpClientFixture)
            : base(mockHttpClientFixture)
        {
            this.service = new AccountService();
        }

        [Fact]
        public void Serialize()
        {
            var options = new AccountCreateOptions
            {
                Individual = new PersonCreateOptions
                {
                    FirstName = "first name",
                    LastName = "last name",
                },
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?individual[first_name]=first+name&individual[last_name]=last+name", url);
        }
    }
}
