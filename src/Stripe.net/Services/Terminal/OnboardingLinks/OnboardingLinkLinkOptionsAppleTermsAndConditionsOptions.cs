// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OnboardingLinkLinkOptionsAppleTermsAndConditionsOptions : INestedOptions
    {
        /// <summary>
        /// Whether the link should also support users relinking their Apple account.
        /// </summary>
        [JsonProperty("allow_relinking")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allow_relinking")]
#endif
        public bool? AllowRelinking { get; set; }

        /// <summary>
        /// The business name of the merchant accepting Apple's Terms and Conditions.
        /// </summary>
        [JsonProperty("merchant_display_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchant_display_name")]
#endif
        public string MerchantDisplayName { get; set; }
    }
}
