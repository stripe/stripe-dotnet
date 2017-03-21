namespace Stripe.Tests.test_data
{
    public static class stripe_token_create_options
    {
        public static StripeTokenCreateOptions Valid()
        {
            var cardOptions = new StripeCreditCardOptions()
            {
                AddressCountry = "US",
                AddressLine1 = "24 Chicken Leg Ave",
                AddressLine2 = "Unit B",
                AddressState = "NC",
                AddressZip = "27617",
                Cvc = "1223",
                ExpirationMonth = "10",
                ExpirationYear = "2021",
                Name = "Bob Winghead",
                Number = "4242424242424242"
            };

            return new StripeTokenCreateOptions()
            {
                Card = cardOptions
            };
        }

        public static StripeTokenCreateOptions ValidDebitCard()
        {
            var cardOptions = new StripeCreditCardOptions()
            {
                AddressCountry = "US",
                AddressLine1 = "123 Shawshank Way",
                AddressLine2 = "(Red) Cell #237",
                AddressState = "NC",
                AddressZip = "27617",
                Cvc = "1223",
                ExpirationMonth = "10",
                ExpirationYear = "2021",
                Name = "Andy Dufresne",
                Number = "4000056655665556",
                Currency = "usd"
            };

            return new StripeTokenCreateOptions()
            {
                Card = cardOptions
            };
        }

        public static StripeTokenCreateOptions ValidForRadar()
        {
            var cardOptions = new StripeCreditCardOptions()
            {
               
                ExpirationMonth = "06",
                ExpirationYear = "2020",
                Number = "4000000000009235"
            };

            return new StripeTokenCreateOptions()
            {
                Card = cardOptions
            };
        }
    }
}
