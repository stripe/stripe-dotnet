// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationMerchantBrandingOptions : INestedOptions
    {
        /// <summary>
        /// ID of a <a href="https://docs.stripe.com/api/persons/update#create_file">file
        /// upload</a>: An icon for the merchant. Must be square and at least 128px x 128px.
        /// </summary>
        [JsonProperty("icon")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("icon")]
#endif
        public string Icon { get; set; }

        /// <summary>
        /// ID of a <a href="https://docs.stripe.com/api/persons/update#create_file">file
        /// upload</a>: A logo for the merchant that will be used in Checkout instead of the icon
        /// and without the merchant's name next to it if provided. Must be at least 128px x 128px.
        /// </summary>
        [JsonProperty("logo")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("logo")]
#endif
        public string Logo { get; set; }

        /// <summary>
        /// A CSS hex color value representing the primary branding color for the merchant.
        /// </summary>
        [JsonProperty("primary_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_color")]
#endif
        public string PrimaryColor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the secondary branding color for the merchant.
        /// </summary>
        [JsonProperty("secondary_color")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("secondary_color")]
#endif
        public string SecondaryColor { get; set; }
    }
}
