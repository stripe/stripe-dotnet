namespace Stripe.Tests.test_data
{
    public static class stripe_token_create_options
    {
        public static StripeTokenCreateOptions Valid()
        {
            // While we should not use raw PANs anymore in Tests we keep this code
            // to properly test the token creation API
            var cardOptions = new StripeCreditCardOptions()
            {
                AddressCountry = "US",
                AddressLine1 = "24 Chicken Leg Ave",
                AddressLine2 = "Unit B",
                AddressState = "NC",
                AddressZip = "27617",
                Cvc = "1223",
                ExpirationMonth = 10,
                ExpirationYear = 2021,
                Name = "Bob Winghead",
                Number = "4242424242424242"
            };

            return new StripeTokenCreateOptions()
            {
                Card = cardOptions
            };
        }
    }
}
