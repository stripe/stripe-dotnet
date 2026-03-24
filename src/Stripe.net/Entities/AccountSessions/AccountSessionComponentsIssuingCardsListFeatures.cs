// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsIssuingCardsListFeatures : StripeEntity<AccountSessionComponentsIssuingCardsListFeatures>
    {
        /// <summary>
        /// Whether to allow card management features.
        /// </summary>
        [JsonProperty("card_management")]
        [STJS.JsonPropertyName("card_management")]
        public bool CardManagement { get; set; }

        /// <summary>
        /// Whether to allow card spend dispute management features.
        /// </summary>
        [JsonProperty("card_spend_dispute_management")]
        [STJS.JsonPropertyName("card_spend_dispute_management")]
        public bool CardSpendDisputeManagement { get; set; }

        /// <summary>
        /// Whether to allow cardholder management features.
        /// </summary>
        [JsonProperty("cardholder_management")]
        [STJS.JsonPropertyName("cardholder_management")]
        public bool CardholderManagement { get; set; }

        /// <summary>
        /// Whether Stripe user authentication is disabled. This value can only be <c>true</c> for
        /// accounts where <c>controller.requirement_collection</c> is <c>application</c> for the
        /// account. The default value is the opposite of the <c>external_account_collection</c>
        /// value. For example, if you don't set <c>external_account_collection</c>, it defaults to
        /// <c>true</c> and <c>disable_stripe_user_authentication</c> defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("disable_stripe_user_authentication")]
        [STJS.JsonPropertyName("disable_stripe_user_authentication")]
        public bool DisableStripeUserAuthentication { get; set; }

        /// <summary>
        /// Whether to allow spend control management features.
        /// </summary>
        [JsonProperty("spend_control_management")]
        [STJS.JsonPropertyName("spend_control_management")]
        public bool SpendControlManagement { get; set; }
    }
}
