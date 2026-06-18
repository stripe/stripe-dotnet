// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentLatestPayout : StripeEntity<PayoutIntentLatestPayout>
    {
        /// <summary>
        /// The ID of the OutboundPayment, if applicable.
        /// </summary>
        [JsonProperty("outbound_payment")]
        [STJS.JsonPropertyName("outbound_payment")]
        public string OutboundPayment { get; set; }

        /// <summary>
        /// The ID of the OutboundTransfer, if applicable.
        /// </summary>
        [JsonProperty("outbound_transfer")]
        [STJS.JsonPropertyName("outbound_transfer")]
        public string OutboundTransfer { get; set; }

        /// <summary>
        /// The type of payout.
        /// One of: <c>outbound_payment</c>, or <c>outbound_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
