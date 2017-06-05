using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_creating_additional_owners_empty_list
    {
        private StripeAccount Account { get; }

        public when_creating_additional_owners_empty_list()
        {
            Account = new StripeAccountService(Cache.ApiKey).Create(
                new StripeAccountCreateOptions
                {
                    Email = "happy@gilmore.com",
                    Type = StripeAccountType.Custom,
                    LegalEntity = new StripeAccountLegalEntityOptions
                    {
                        AdditionalOwners = new List<StripeAccountAdditionalOwner>()
                    }
                }
            ); 
        }

        [Fact]
        public void has_an_empty_list_of_additional_owners()
        {
            Account.Should().NotBeNull();
            Account.LegalEntity.AdditionalOwners.Should().NotBeNull();
            Account.LegalEntity.AdditionalOwners.Count.Should().Be(0);
        }
    }
}
