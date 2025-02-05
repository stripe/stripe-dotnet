// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountSessionComponentsIssuingCardsListFeatures : StripeEntity<AccountSessionComponentsIssuingCardsListFeatures>
    {
        /// <summary>
        /// Whether to allow card management features.
        /// </summary>
        [JsonProperty("card_management")]
        public bool CardManagement { get; set; }

        /// <summary>
        /// Whether to allow card spend dispute management features.
        /// </summary>
        [JsonProperty("card_spend_dispute_management")]
        public bool CardSpendDisputeManagement { get; set; }

        /// <summary>
        /// Whether to allow cardholder management features.
        /// </summary>
        [JsonProperty("cardholder_management")]
        public bool CardholderManagement { get; set; }

        /// <summary>
        /// Disables Stripe user authentication for this embedded component. This feature can only
        /// be false for accounts where you’re responsible for collecting updated information when
        /// requirements are due or change, like custom accounts.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow spend control management features.
        /// </summary>
        [JsonProperty("spend_control_management")]
        public bool SpendControlManagement { get; set; }
    }
}
