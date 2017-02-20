using System;
using System.Collections.Generic;
using Stripe.Infrastructure;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class when_no_additional_owners : test
    {
        private StripeAccountCreateOptions AccountOptions { get; }
        private String AccountJSON { get; }

        public when_no_additional_owners()
        {
            AccountOptions =
                new StripeAccountCreateOptions
                {
                    Email = $"merry@christmas.com",
                    Managed = true,
                    LegalEntity = new StripeAccountLegalEntityOptions
                    {
                        AdditionalOwners = new List<StripeAccountAdditionalOwner> { }
                    }
                };
        }

        [Fact]
        public void has_legal_entity()
        {
            var accountString = new StripeAccountService(_stripe_api_key).ApplyAllParameters(AccountOptions, $"{Urls.BaseUrl}/accounts", false);
            accountString.Should().Contain("legal_entity[additional_owners]");
        }
    }
}

