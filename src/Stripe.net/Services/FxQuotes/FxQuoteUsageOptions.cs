// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteUsageOptions : INestedOptions
    {
        /// <summary>
        /// The payment transaction details that are intended for the FX Quote.
        /// </summary>
        [JsonProperty("payment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment")]
#endif
        public FxQuoteUsagePaymentOptions Payment { get; set; }

        /// <summary>
        /// The transfer transaction details that are intended for the FX Quote.
        /// </summary>
        [JsonProperty("transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transfer")]
#endif
        public FxQuoteUsageTransferOptions Transfer { get; set; }

        /// <summary>
        /// Which transaction the FX Quote will be used for.
        ///
        /// Can be “payment” | “transfer”.
        /// One of: <c>payment</c>, or <c>transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
