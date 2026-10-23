// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountSessionResourceComponentsIssuingCardScopes : StripeEntity<AccountSessionResourceComponentsIssuingCardScopes>
    {
        /// <summary>
        /// Whether to allow managing Issuing cardholders.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_cardholders")]
        [STJS.JsonPropertyName("manage_issuing_cardholders")]
        public string ManageIssuingCardholders { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing cards.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_cards")]
        [STJS.JsonPropertyName("manage_issuing_cards")]
        public string ManageIssuingCards { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing disputes.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_disputes")]
        [STJS.JsonPropertyName("manage_issuing_disputes")]
        public string ManageIssuingDisputes { get; set; }

        /// <summary>
        /// Whether to allow managing Issuing spending controls.
        /// One of: <c>disabled</c>, or <c>enabled</c>.
        /// </summary>
        [JsonProperty("manage_issuing_spending_controls")]
        [STJS.JsonPropertyName("manage_issuing_spending_controls")]
        public string ManageIssuingSpendingControls { get; set; }
    }
}
