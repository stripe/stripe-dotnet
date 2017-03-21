namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeToken GetToken()
        {
            if (Items.ContainsKey("token")) return (StripeToken) Items["token"];

            var token = new StripeTokenService(ApiKey).Create(GetTokenCreateOptions());
            Items.Add("token", token);

            return token;
        }

        public static StripeTokenCreateOptions GetTokenCreateOptions()
        {
            if (Items.ContainsKey("token_create_options")) return (StripeTokenCreateOptions) Items["token_create_options"];

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
                    ExpirationMonth = "10",
                    ExpirationYear = "2025",
                    Number = "4242424242424242"
                }
            };
            Items.Add("token_create_options", options);

            return options;
        }
    }
}
