using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_charge_create_options
    {
        public static StripeChargeCreateOptions ValidCard()
        {
            return new StripeChargeCreateOptions()
            {
                SourceTokenOrExistingSourceId = "tok_bypassPending",
                Description = "my charge description",
                StatementDescriptor = "my statement",
                Amount = 5153,
                Currency = "usd",
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                }
            };
        }

        public static StripeChargeCreateOptions ValidTokenWithDestination(string tokenId, string destinationAccountId, int? destinationAmount)
        {
            return new StripeChargeCreateOptions()
            {
                SourceTokenOrExistingSourceId = tokenId,
                Destination = destinationAccountId,
                DestinationAmount = destinationAmount.GetValueOrDefault(),
                Amount = 8675309,
                Currency = "usd"
            };
        }

        public static StripeChargeCreateOptions InvalidCard()
        {
            return new StripeChargeCreateOptions()
            {
                SourceTokenOrExistingSourceId = "tok_chargeDeclined",
                Description = "my charge description",
                StatementDescriptor = "my statement",
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
                SourceTokenOrExistingSourceId = _tokenId
            };
        }
    }
}