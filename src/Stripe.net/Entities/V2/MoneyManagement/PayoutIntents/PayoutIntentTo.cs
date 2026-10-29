// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutIntentTo : StripeEntity<PayoutIntentTo>
    {
        /// <summary>
        /// Estimated amount to be credited to the recipient in the destination currency.
        /// </summary>
        [JsonProperty("credited")]
        [STJS.JsonPropertyName("credited")]
        public V2.Amount Credited { get; set; }

        /// <summary>
        /// The currency to send to the recipient.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The payout method ID for the PayoutIntent. Optional when the PayoutIntent creates an
        /// OutboundPayment and the recipient has a default payout method. Required when the
        /// PayoutIntent creates an OutboundTransfer.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// Payout method options for the PayoutIntent.
        /// </summary>
        [JsonProperty("payout_method_options")]
        [STJS.JsonPropertyName("payout_method_options")]
        public PayoutIntentToPayoutMethodOptions PayoutMethodOptions { get; set; }

        /// <summary>
        /// The recipient ID for the PayoutIntent.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }
    }
}
