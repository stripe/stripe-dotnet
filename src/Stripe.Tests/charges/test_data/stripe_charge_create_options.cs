using System.Collections.Generic;
namespace Stripe.Tests.test_data
{
    public static class stripe_charge_create_options
    {
        public static StripeChargeCreateOptions ValidCard()
        {
            var cardOptions = new StripeSourceOptions()
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
                Number = "4000000000000077",
            };

            return new StripeChargeCreateOptions()
            {
                Source = cardOptions,
                Description = "Joe Meatball Charge",
                StatementDescriptor = "Joe Meatball Sub",
                Amount = 5153,
                Currency = "usd",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };
        }

        public static StripeChargeCreateOptions DisputedCard()
        {
            var cardOptions = new StripeSourceOptions()
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
                Number = "4000000000000259",
            };

            return new StripeChargeCreateOptions()
            {
                Source = cardOptions,
                Description = "Joe Meatball Charge",
                StatementDescriptor = "Joe Meatball Sub",
                Amount = 5153,
                Currency = "usd",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };
        }

        public static StripeChargeCreateOptions InvalidCard()
        {
            var cardOptions = new StripeSourceOptions()
            {
                AddressCountry = "US",
                AddressLine1 = "24 Poopie St",
                AddressCity = "Yeehaw Beebop ChickyChicky",
                AddressState = "NC",
                AddressZip = "90210",
                Cvc = "1223",
                ExpirationMonth = "10",
                ExpirationYear = "2004",
                Name = "Joe Meatballs",
                Number = "425221"
            };

            return new StripeChargeCreateOptions()
            {
                Source = cardOptions,
                Description = "Joe Meatball Charge",
                StatementDescriptor = "Joe Meatball Sub",
                Amount = 5153,
                Currency = "usd"
            };
        }

        public static StripeChargeCreateOptions ValidCustomer(string customerId)
        {
            return new StripeChargeCreateOptions()
            {
                Description = "Buddy Roast (beef@email.com)",
                StatementDescriptor = "Joe Meatball Sub",
                Amount = 2994,
                Currency = "usd",
                CustomerId = customerId
            };
        }

        public static StripeChargeCreateOptions ValidToken(string _tokenId)
        {
            return new StripeChargeCreateOptions()
            {
                Amount = 2001,
                Currency = "usd",
                Source = new StripeSourceOptions() { TokenId = _tokenId }
            };
        }
    }
}