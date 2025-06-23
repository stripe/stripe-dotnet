// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSessionComponentsIssuingCardsListFeatures : StripeEntity<AccountSessionComponentsIssuingCardsListFeatures>
    {
        /// <summary>
        /// Whether to allow card management features.
        /// </summary>
        [JsonProperty("card_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_management")]
#endif
        public bool CardManagement { get; set; }

        /// <summary>
        /// Whether to allow card spend dispute management features.
        /// </summary>
        [JsonProperty("card_spend_dispute_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_spend_dispute_management")]
#endif
        public bool CardSpendDisputeManagement { get; set; }

        /// <summary>
        /// Whether to allow cardholder management features.
        /// </summary>
        [JsonProperty("cardholder_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder_management")]
#endif
        public bool CardholderManagement { get; set; }

        /// <summary>
        /// Whether Stripe user authentication is disabled. This value can only be <c>true</c> for
        /// accounts where <c>controller.requirement_collection</c> is <c>application</c> for the
        /// account. The default value is the opposite of the <c>external_account_collection</c>
        /// value. For example, if you don't set <c>external_account_collection</c>, it defaults to
        /// <c>true</c> and <c>disable_stripe_user_authentication</c> defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
#endif
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow spend control management features.
        /// </summary>
        [JsonProperty("spend_control_management")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("spend_control_management")]
#endif
        public bool SpendControlManagement { get; set; }
    }
}
