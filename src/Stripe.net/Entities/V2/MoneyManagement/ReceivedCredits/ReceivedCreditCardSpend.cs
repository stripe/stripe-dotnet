// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditCardSpend : StripeEntity<ReceivedCreditCardSpend>
    {
        /// <summary>
        /// The reference to the issuing card object.
        /// </summary>
        [JsonProperty("card_v1_id")]
        [STJS.JsonPropertyName("card_v1_id")]
        public string CardV1Id { get; set; }

        /// <summary>
        /// Hash containing information about the Dispute that triggered this credit.
        /// </summary>
        [JsonProperty("dispute")]
        [STJS.JsonPropertyName("dispute")]
        public ReceivedCreditCardSpendDispute Dispute { get; set; }

        /// <summary>
        /// Hash containing information about the Refund that triggered this credit.
        /// </summary>
        [JsonProperty("refund")]
        [STJS.JsonPropertyName("refund")]
        public ReceivedCreditCardSpendRefund Refund { get; set; }
    }
}
