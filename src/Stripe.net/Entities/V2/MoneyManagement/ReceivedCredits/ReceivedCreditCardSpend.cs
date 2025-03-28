// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditCardSpend : StripeEntity<ReceivedCreditCardSpend>
    {
        /// <summary>
        /// The reference to the issuing card object.
        /// </summary>
        [JsonProperty("card_v1_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_v1_id")]
#endif
        public string CardV1Id { get; set; }

        /// <summary>
        /// Hash containing information about the Dispute that triggered this credit.
        /// </summary>
        [JsonProperty("dispute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dispute")]
#endif
        public ReceivedCreditCardSpendDispute Dispute { get; set; }

        /// <summary>
        /// Hash containing information about the Refund that triggered this credit.
        /// </summary>
        [JsonProperty("refund")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund")]
#endif
        public ReceivedCreditCardSpendRefund Refund { get; set; }
    }
}
