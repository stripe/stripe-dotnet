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
                DebitNegativeBalances = true,
                DeclineChargeOnAvsFailure = false,
                DeclineChargeOnCvcFailure = true,
                DefaultCurrency = "usd",
                Email = $"Debra{Guid.NewGuid()}@gmail.com",

                ExternalCardAccount = new StripeAccountCardOptions()
                {
                    AddressCountry = "US",
                    AddressLine1 = "24 Beef Flank St",
                    AddressLine2 = "Apt 24",
                    AddressCity = "BIGGIE",
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

                ExternalBankAccount = new StripeAccountBankAccountOptions()
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderType = "company",
                    AccountHolderName = "Jayme Inc",
                    Name = "Jayme Inc",
                    RoutingNumber = "110000000"
                }
            };
        }
    }
}