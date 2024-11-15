// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerFundCashBalanceOptions : BaseOptions
    {
        /// <summary>
        /// Amount to be used for this test cash balance transaction. A positive integer
        /// representing how much to fund in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to fund $1.00 or 100 to fund ¥100, a zero-decimal currency).
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif

        public long? Amount { get; set; }

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

        /// <summary>
        /// A description of the test funding. This simulates free-text references supplied by
        /// customers when making bank transfers to their cash balance. You can use this to test how
        /// Stripe's <a
        /// href="https://stripe.com/docs/payments/customer-balance/reconciliation">reconciliation
        /// algorithm</a> applies to different user inputs.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif

        public string Reference { get; set; }
    }
}
