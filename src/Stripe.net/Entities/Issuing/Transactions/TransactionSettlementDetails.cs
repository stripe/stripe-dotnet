// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionSettlementDetails : StripeEntity<TransactionSettlementDetails>
    {
        /// <summary>
        /// <c>merchant_amount</c> in the settlement currency.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Settlement currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Exchange rate used by the network to convert the <c>merchant_amount</c> to
        /// <c>settlement_details.amount</c>. The <c>merchant_amount</c> multiplied with this rate
        /// will equal to the <c>settlement_details.amount</c>.
        /// </summary>
        [JsonProperty("exchange_rate")]
        [STJS.JsonPropertyName("exchange_rate")]
        public decimal? ExchangeRate { get; set; }
    }
}
