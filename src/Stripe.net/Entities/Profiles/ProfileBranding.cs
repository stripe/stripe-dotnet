// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProfileBranding : StripeEntity<ProfileBranding>
    {
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public ProfileBrandingIcon Icon { get; set; }

        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public ProfileBrandingLogo Logo { get; set; }

        [JsonProperty("primary_color")]
        [STJS.JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        [JsonProperty("secondary_color")]
        [STJS.JsonPropertyName("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
