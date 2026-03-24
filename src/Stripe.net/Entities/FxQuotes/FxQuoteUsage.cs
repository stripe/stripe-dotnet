// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FxQuoteUsage : StripeEntity<FxQuoteUsage>
    {
        /// <summary>
        /// The details required to use an FX Quote for a payment.
        /// </summary>
        [JsonProperty("payment")]
        [STJS.JsonPropertyName("payment")]
        public FxQuoteUsagePayment Payment { get; set; }

        /// <summary>
        /// The details required to use an FX Quote for a transfer.
        /// </summary>
        [JsonProperty("transfer")]
        [STJS.JsonPropertyName("transfer")]
        public FxQuoteUsageTransfer Transfer { get; set; }

        /// <summary>
        /// The transaction type for which the FX Quote will be used.
        ///
        /// Can be 'payment' or 'transfer'.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
