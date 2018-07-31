namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class StripeAccountCreateOptionsTest : BaseStripeTest
    {
        private StripeAccountService service;

        public StripeAccountCreateOptionsTest()
        {
            this.service = new StripeAccountService();
        }

        [Fact]
        public void SerializeAdditionalOwnersProperly()
        {
            var options = new StripeAccountCreateOptions
            {
                LegalEntity = new StripeAccountLegalEntityOptions
                {
                    AdditionalOwners = new List<StripeAccountAdditionalOwner>()
                },
            };

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal("?legal_entity[additional_owners]=", url);
        }
    }
}
