// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteUsage : StripeEntity<FxQuoteUsage>
    {
        /// <summary>
        /// The details required to use an FX Quote for a payment.
        /// </summary>
        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public FxQuoteUsagePayment Payment { get; set; }

        /// <summary>
        /// The details required to use an FX Quote for a transfer.
        /// </summary>
        [JsonProperty("transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer")]
#endif
        public FxQuoteUsageTransfer Transfer { get; set; }

        /// <summary>
        /// The transaction type for which the FX Quote will be used.
        ///
        /// Can be 'payment' or 'transfer'.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
