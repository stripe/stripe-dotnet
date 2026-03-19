// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OnboardingLinkLinkOptionsAppleTermsAndConditions : StripeEntity<OnboardingLinkLinkOptionsAppleTermsAndConditions>
    {
        /// <summary>
        /// Whether the link should also support users relinking their Apple account.
        /// </summary>
        [JsonProperty("allow_relinking")]
        [STJS.JsonPropertyName("allow_relinking")]
        public bool? AllowRelinking { get; set; }

        /// <summary>
        /// The business name of the merchant accepting Apple's Terms and Conditions.
        /// </summary>
        [JsonProperty("merchant_display_name")]
        [STJS.JsonPropertyName("merchant_display_name")]
        public string MerchantDisplayName { get; set; }
    }
}
