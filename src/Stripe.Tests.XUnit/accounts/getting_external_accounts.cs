using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.xUnit
{
    public class getting_external_accounts : test
    {
        private StripeAccount RetrievedAccount { get; }

        public getting_external_accounts()
        {
            var newAccount = new StripeAccountService(_stripe_api_key).Create(
                new StripeAccountCreateOptions
                {
                    BusinessName = "Subtracts",
                    BusinessPrimaryColor = "#" + new Random().Next(0, 6).ToString("D6"),
                    BusinessUrl = "http://subtracts.io",
                    DebitNegativeBalances = true,
                    DeclineChargeOnAvsFailure = false,
                    DeclineChargeOnCvcFailure = true,
                    DefaultCurrency = "usd",
                    Email = $"some_test@someotheremail.com",
                    Managed = true,
                    ExternalCardAccount = new StripeAccountCardOptions()
                    {
                        AddressCountry = "US",
                        AddressLine1 = "24 Main St",
                        AddressLine2 = "Apt 24",
                        AddressCity = "Raleigh",
                        AddressState = "NC",
                        AddressZip = "27617",
                        Cvc = "1223",
                        ExpirationMonth = "10",
                        ExpirationYear = "2021",
                        Name = "Joe Meatballs",
                        Number = "4000056655665556",
                        Currency = "usd",
                        DefaultForCurrency = true
                    }
                }
            );

            RetrievedAccount = new StripeAccountService(_stripe_api_key).Get(newAccount.Id);
        }

        [Fact]
        public void has_object()
        {
            RetrievedAccount.ExternalAccounts.Object.Should().NotBeNull();
        }

        [Fact]
        public void has_total_count()
        {
            RetrievedAccount.ExternalAccounts.TotalCount.ShouldBeEquivalentTo(1);
        }

        [Fact]
        public void has_url()
        {
            RetrievedAccount.ExternalAccounts.Url.Should().NotBeNull();
        }
    }
}

