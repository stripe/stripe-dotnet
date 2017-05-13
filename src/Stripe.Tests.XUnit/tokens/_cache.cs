namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeToken GetToken()
        {
            return new StripeTokenService(ApiKey).Create(GetTokenCreateOptions());
        }

        public static StripeTokenCreateOptions GetTokenCreateOptions()
        {
            var options = new StripeTokenCreateOptions
            {
                Card = new StripeCreditCardOptions
                {
                    Name = "Jason Isbell",
                    AddressCity = "Green Hill",
                    AddressState = "AL",
                    AddressLine1 = "I could ask?",
                    AddressLine2 = "",
                    AddressZip = "35636",
                    AddressCountry = "US",
                    Cvc = "123",
                    ExpirationMonth = 10,
                    ExpirationYear = 2025,
                    Number = "4242424242424242"
                }
            };

            return options;
        }
    }
}
