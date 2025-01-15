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
        /// Disables Stripe user authentication for this embedded component. This feature can only
        /// be false for accounts where you’re responsible for collecting updated information when
        /// requirements are due or change, like custom accounts.
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
