// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionComponentsIssuingCardFeatures : StripeEntity<AccountSessionComponentsIssuingCardFeatures>
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
        /// Whether to allow spend control management features.
        /// </summary>
        [JsonProperty("spend_control_management")]
        [STJS.JsonPropertyName("spend_control_management")]
        public bool SpendControlManagement { get; set; }
    }
}
