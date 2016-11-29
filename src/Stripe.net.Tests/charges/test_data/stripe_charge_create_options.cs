using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_charge_create_options
    {
        public static StripeChargeCreateOptions ValidCard()
        {
            // obsolete: var cardOptions = new StripeSourceOptions()
            var cardOptions = new SourceCard()
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
                Number = "4000000000000077"
            };

            return new StripeChargeCreateOptions()
            {
                // obsolete: Source = cardOptions,
                SourceCard = cardOptions,
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

        public static StripeChargeCreateOptions ValidTokenWithDestination(string tokenId, string destinationAccountId)
        {
            return new StripeChargeCreateOptions()
            {
                SourceTokenOrExistingSourceId = tokenId,
                Destination = destinationAccountId,
                Amount = 8675309,
                Currency = "usd"
            };
        }

        public static StripeChargeCreateOptions InvalidCard()
        {
            // obsolete: var cardOptions = new StripeSourceOptions()
            var cardOptions = new SourceCard()
            {
                AddressCountry = "US",
                AddressLine1 = "24 Lynbrook St",
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
                // obsolete: Source = cardOptions,
                SourceCard = cardOptions,
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
                // obsolete: Source = new StripeSourceOptions() { TokenId = _tokenId }
                SourceTokenOrExistingSourceId =  _tokenId
            };
        }
    }
}