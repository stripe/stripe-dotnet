// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsNotificationBannerFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Disables Stripe user authentication for this embedded component. This feature can only
        /// be <c>true</c> for accounts where you’re responsible for collecting updated information
        /// when requirements are due or change, like Custom accounts. The default value for this
        /// feature is <c>false</c> when <c>external_account_collection</c> is enabled and
        /// <c>true</c> otherwise.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
#endif
        public bool? DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow platforms to control bank account collection for their connected
        /// accounts. This feature can only be false for accounts where you’re responsible for
        /// collecting updated information when requirements are due or change, like custom
        /// accounts. Otherwise, bank account collection is determined by compliance requirements.
        /// The default value for this feature is <c>true</c>.
        /// </summary>
        [JsonProperty("external_account_collection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_account_collection")]
#endif
        public bool? ExternalAccountCollection { get; set; }
    }
}
