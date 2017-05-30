using System;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeAccount GetAccount()
        {
            return new StripeAccountService(ApiKey).Create(GetAccountCreateOptions());
        }

        public static StripeAccountCreateOptions GetAccountCreateOptions()
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
