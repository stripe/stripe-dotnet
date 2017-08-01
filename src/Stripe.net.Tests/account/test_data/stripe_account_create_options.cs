using System;

namespace Stripe.Tests.test_data
{
    public static class stripe_account_create_options
    {
        public static StripeAccountCreateOptions ValidAccountWithCard()
        {
            return new StripeAccountCreateOptions()
            {
                BusinessName = "created-business-name-" + Guid.NewGuid(),
                BusinessPrimaryColor = "#" + new Random().Next(0, 6).ToString("D6"),
                BusinessUrl = "http://created.com/" + Guid.NewGuid(),
                Country = "US",
                DebitNegativeBalances = true,
                DeclineChargeOnAvsFailure = false,
                DeclineChargeOnCvcFailure = true,
                DefaultCurrency = "usd",
                Email = $"Debra{Guid.NewGuid()}@gmail.com",
                Type = StripeAccountType.Custom,

                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    TokenId = "tok_visa_debit"
                }
            };
        }

        public static StripeAccountCreateOptions ValidAccountWithBankAccount()
        {
            return new StripeAccountCreateOptions()
            {
                BusinessName = "created-business-name-" + Guid.NewGuid(),
                BusinessPrimaryColor = "#" + new Random().Next(0, 6).ToString("D6"),
                BusinessUrl = "http://created.com/" + Guid.NewGuid(),
                DebitNegativeBalances = true,
                DeclineChargeOnAvsFailure = false,
                DeclineChargeOnCvcFailure = true,
                DefaultCurrency = "usd",
                Type = StripeAccountType.Custom,

                ExternalBankAccount = new StripeAccountBankAccountOptions()
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderType = "company",
                    AccountHolderName = "Jayme Inc",
                    RoutingNumber = "110000000"
                }
            };
        }
    }
}