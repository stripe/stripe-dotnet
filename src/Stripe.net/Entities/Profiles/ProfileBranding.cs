// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProfileBranding : StripeEntity<ProfileBranding>
    {
        [JsonProperty("icon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("icon")]
#endif
        public ProfileBrandingIcon Icon { get; set; }

        [JsonProperty("logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo")]
#endif
        public ProfileBrandingLogo Logo { get; set; }

        [JsonProperty("primary_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_color")]
#endif
        public string PrimaryColor { get; set; }

        [JsonProperty("secondary_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secondary_color")]
#endif
        public string SecondaryColor { get; set; }
    }
}
