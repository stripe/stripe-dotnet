using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public class stripe_recipient_create_options
    {
        public static StripeRecipientCreateOptions ValidIndividual()
        {
            var stripeRecipientCreateOptions = new StripeRecipientCreateOptions()
            {
                Name = "Johnny Tenderloin",
                Type = "individual",
                TaxId = "000000000",
                BankAccount = new StripeBankAccountOptions()
                {
                    AccountNumber = "000123456789",
                    RoutingNumber = "110000000",
                    Country = "US"
                },
                Email = "pork@email.com",
                Description = "Johnny Tenderloin (pork@email.com)",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeRecipientCreateOptions;
        }

        public static StripeRecipientCreateOptions ValidCorporation()
        {
            var stripeRecipientCreateOptions = new StripeRecipientCreateOptions()
            {
                Name = "Tenderloin International, Ltd.",
                Type = "corporation",
                TaxId = "000000000",
                BankAccount = new StripeBankAccountOptions()
                {
                    AccountNumber = "000123456789",
                    RoutingNumber = "110000000",
                    Country = "US"
                },
                Email = "tenderloins@email.com",
                Description = "Tenderloin International (tenderloins@email.com)",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeRecipientCreateOptions;
        }

        public static StripeRecipientCreateOptions TransferFailCorporation()
        {
            var stripeRecipientCreateOptions = new StripeRecipientCreateOptions()
            {
                Name = "Tenderloin International, Ltd.",
                Type = "corporation",
                TaxId = "000000000",
                BankAccount = new StripeBankAccountOptions()
                {
                    AccountNumber = "000111111116",
                    RoutingNumber = "110000000",
                    Country = "US"
                },
                Email = "tenderloins@email.com",
                Description = "Tenderloin International (tenderloins@email.com)",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };

            return stripeRecipientCreateOptions;
        }
    }
}