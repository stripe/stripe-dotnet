namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OAuthTokenCreateOptions : BaseOptions
    {
        [JsonProperty("assert_capabilities")]
        public List<string> AssertCapabilities { get; set; }

        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("grant_type")]
        public string GrantType { get; set; }

        [JsonProperty("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}
