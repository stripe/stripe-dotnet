using System;
using System.Linq;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class listing_external_accounts : test
    {
        private IEnumerable<StripeAccount> DefaultLimitAllRetrievedAccounts { get; }
        private IEnumerable<StripeAccount> Limit4RetrievedAccounts { get; }

        public listing_external_accounts()
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

            DefaultLimitAllRetrievedAccounts = new StripeAccountService(_stripe_api_key).List();

            Limit4RetrievedAccounts = new StripeAccountService(_stripe_api_key).List(new StripeListOptions { Limit = 4 });
        }

        [Fact]
        public void has_default_limit_min_total_count()
        {
            DefaultLimitAllRetrievedAccounts.ToList().Count().Should().BeGreaterOrEqualTo(1);
        }

        [Fact]
        public void has_default_limit_max_total_count()
        {
            DefaultLimitAllRetrievedAccounts.ToList().Count().Should().BeLessOrEqualTo(10);
        }

        [Fact]
        public void has_specified_limit_min_total_count()
        {
            Limit4RetrievedAccounts.ToList().Count().Should().BeGreaterOrEqualTo(1);
        }

        [Fact]
        public void has_specified_limit_max_total_count()
        {
            Limit4RetrievedAccounts.ToList().Count().Should().BeLessOrEqualTo(4);
        }
    }
}

