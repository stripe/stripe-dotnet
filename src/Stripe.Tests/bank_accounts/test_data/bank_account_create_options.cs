using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class bank_account_create_options
    {
        public static BankAccountCreateOptions ValidBankAccount()
        {
            return new BankAccountCreateOptions
            {
                SourceBankAccount = new SourceBankAccount()
                {
                    AccountNumber = "000123456789",
                    Country = "US",
                    Currency = "usd",
                    AccountHolderName = "Frank",
                    AccountHolderType = BankAccountHolderType.Company,
                    RoutingNumber = "110000000",
                    Metadata = new Dictionary<string, string>
                    {
                        { "Name", "Ray Barone" },
                        { "OftenSays", "Thatttttt's right" }
                    }
                }
            };
        }
    }
}
