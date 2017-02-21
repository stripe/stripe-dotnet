using System;
using System.Collections.Generic;
using Stripe.Infrastructure;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_additional_owners_is_empty_list : test
    {
        private StripeAccount Account { get; set; }

        public when_additional_owners_is_empty_list()
        {
            Account = new StripeAccountService(_stripe_api_key).Create(
                new StripeAccountCreateOptions
                {
                    Email = $"happy@gilmore.com",
                    Managed = true,
                    LegalEntity = new StripeAccountLegalEntityOptions
                    {
                        AdditionalOwners = new List<StripeAccountAdditionalOwner> {}
                    }
                }
            ); 
        }

        [Fact]
        public void be_a_valid_account()
        {
            Account.Should().NotBeNull();
        }

        [Fact]
        public void has_valid_additional_owners()
        {
            Account.LegalEntity.AdditionalOwners.Should().NotBeNull();
            Account.LegalEntity.AdditionalOwners.Count.Should().Be(0);
        }
    }
}
