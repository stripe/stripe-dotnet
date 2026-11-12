// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsConnectOldSettings : StripeEntity<ActivityLogDetailsConnectOldSettings>
    {
        /// <summary>
        /// The display name shown on the onboarding experience and Dashboard. This is different
        /// from the business legal name.
        /// </summary>
        [JsonProperty("business_name")]
        [STJS.JsonPropertyName("business_name")]
        public string BusinessName { get; set; }

        /// <summary>
        /// Whether platform branding is copied to new connected accounts. These also appear on
        /// invoices, receipts, and other Stripe products.
        /// </summary>
        [JsonProperty("copy_platform_branding_to_new_connected_accounts")]
        [STJS.JsonPropertyName("copy_platform_branding_to_new_connected_accounts")]
        public bool? CopyPlatformBrandingToNewConnectedAccounts { get; set; }

        /// <summary>
        /// Whether the support email is hidden on onboarding surfaces.
        /// </summary>
        [JsonProperty("hide_onboarding_support_email")]
        [STJS.JsonPropertyName("hide_onboarding_support_email")]
        public bool? HideOnboardingSupportEmail { get; set; }

        /// <summary>
        /// Whether the support phone number is hidden on onboarding surfaces.
        /// </summary>
        [JsonProperty("hide_onboarding_support_phone")]
        [STJS.JsonPropertyName("hide_onboarding_support_phone")]
        public bool? HideOnboardingSupportPhone { get; set; }

        /// <summary>
        /// Whether the support URL is hidden on onboarding surfaces.
        /// </summary>
        [JsonProperty("hide_onboarding_support_url")]
        [STJS.JsonPropertyName("hide_onboarding_support_url")]
        public bool? HideOnboardingSupportUrl { get; set; }

        /// <summary>
        /// Identifier of the icon file (file_* ID).
        /// </summary>
        [JsonProperty("icon")]
        [STJS.JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Identifier of the logo file (file_* ID).
        /// </summary>
        [JsonProperty("logo")]
        [STJS.JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// The platform's default payout statement descriptor. It appears on the bank statements of
        /// the platform's connected accounts for their payouts.
        /// </summary>
        [JsonProperty("payout_statement_descriptor")]
        [STJS.JsonPropertyName("payout_statement_descriptor")]
        public string PayoutStatementDescriptor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the primary branding color, applied to the onboarding
        /// experience and the Stripe Dashboard.
        /// </summary>
        [JsonProperty("primary_color")]
        [STJS.JsonPropertyName("primary_color")]
        public string PrimaryColor { get; set; }

        /// <summary>
        /// A CSS hex color value representing the secondary branding color, applied to the
        /// onboarding experience and the Stripe Dashboard.
        /// </summary>
        [JsonProperty("secondary_color")]
        [STJS.JsonPropertyName("secondary_color")]
        public string SecondaryColor { get; set; }
    }
}
