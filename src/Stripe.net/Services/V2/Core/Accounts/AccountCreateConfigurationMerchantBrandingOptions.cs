// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantBrandingOptions : INestedOptions
    {
        /// <summary>
        /// ID of a <a href="https://docs.stripe.com/api/persons/update#create_file">file
        /// upload</a>: An icon for the merchant. Must be square and at least 128px x 128px.
        /// </summary>
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// ID of a <a href="https://docs.stripe.com/api/persons/update#create_file">file
        /// upload</a>: A logo for the merchant that will be used in Checkout instead of the icon
        /// and without the merchant's name next to it if provided. Must be at least 128px x 128px.
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// A CSS hex color value representing the primary branding color for the merchant.
        /// </summary>
        [JsonProperty("primary_color")]
        [STJS.JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the secondary branding color for the merchant.
        /// </summary>
        [JsonProperty("secondary_color")]
        [STJS.JsonPropertyName("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
