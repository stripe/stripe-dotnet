// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OutboundPaymentQuoteTo : StripeEntity<OutboundPaymentQuoteTo>
    {
        /// <summary>
        /// The monetary amount being credited to the destination.
        /// </summary>
        [JsonProperty("credited")]
        [STJS.JsonPropertyName("credited")]
        public V2.Amount Credited { get; set; }

        /// <summary>
        /// The payout method which the OutboundPayment uses to send payout.
        /// </summary>
        [JsonProperty("payout_method")]
        [STJS.JsonPropertyName("payout_method")]
        public string PayoutMethod { get; set; }

        /// <summary>
        /// To which account the OutboundPayment is sent.
        /// </summary>
        [JsonProperty("recipient")]
        [STJS.JsonPropertyName("recipient")]
        public string Recipient { get; set; }
    }
}
