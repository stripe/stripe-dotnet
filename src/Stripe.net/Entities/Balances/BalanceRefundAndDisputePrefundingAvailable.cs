// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class BalanceRefundAndDisputePrefundingAvailable : StripeEntity<BalanceRefundAndDisputePrefundingAvailable>
    {
        /// <summary>
        /// Balance amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        [JsonProperty("source_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source_types")]
#endif
        public BalanceRefundAndDisputePrefundingAvailableSourceTypes SourceTypes { get; set; }
    }
}
