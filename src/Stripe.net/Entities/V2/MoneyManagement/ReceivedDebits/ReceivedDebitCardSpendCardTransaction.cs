// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitCardSpendCardTransaction : StripeEntity<ReceivedDebitCardSpendCardTransaction>
    {
        /// <summary>
        /// Amount associated with this issuing transaction.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The reference to the v1 issuing transaction ID.
        /// </summary>
        [JsonProperty("issuing_transaction_v1")]
        [STJS.JsonPropertyName("issuing_transaction_v1")]
        public string IssuingTransactionV1 { get; set; }
    }
}
