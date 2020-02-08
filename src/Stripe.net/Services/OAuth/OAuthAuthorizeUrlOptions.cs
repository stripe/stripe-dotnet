namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OAuthAuthorizeUrlOptions : BaseOptions
    {
        [JsonProperty("always_prompt")]
        public bool? AlwaysPrompt { get; set; }

        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        [JsonProperty("response_type")]
        public string ResponseType { get; set; } = "code";

        [JsonProperty("redirect_uri")]
        public string RedirectUri { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("stripe_landing")]
        public string StripeLanding { get; set; }

        [JsonProperty("stripe_user")]
        public OAuthAuthorizeUrlStripeUserOptions StripeUser { get; set; }

        [JsonProperty("suggested_capabilities")]
        public List<string> SuggestedCapabilities { get; set; }
    }
}
