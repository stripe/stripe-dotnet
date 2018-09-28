namespace Stripe
{
    using Stripe.Infrastructure;

    public class OAuthTokenCreateOptions : BaseOptions
    {
        [FormProperty("code")]
        public string Code { get; set; }

        [FormProperty("client_secret")]
        public string ClientSecret { get; set; }

        [FormProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [FormProperty("grant_type")]
        public string GrantType { get; set; }

        [FormProperty("scope")]
        public string Scope { get; set; }
    }
}
