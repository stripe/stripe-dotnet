// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ProfileBranding : StripeEntity<ProfileBranding>
    {
        /// <summary>
        /// Profile icon image.
        /// </summary>
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public ProfileBrandingIcon Icon { get; set; }

        /// <summary>
        /// Profile logo image.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public ProfileBrandingLogo Logo { get; set; }

        /// <summary>
        /// The primary brand color for the profile.
        /// </summary>
        [JsonProperty("primary_color")]
        [STJS.JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// The secondary brand color for the profile.
        /// </summary>
        [JsonProperty("secondary_color")]
        [STJS.JsonPropertyName("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
