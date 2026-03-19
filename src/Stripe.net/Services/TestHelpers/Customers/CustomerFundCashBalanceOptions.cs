// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerFundCashBalanceOptions : BaseOptions
    {
        /// <summary>
        /// Amount to be used for this test cash balance transaction. A positive integer
        /// representing how much to fund in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a> (e.g.,
        /// 100 cents to fund $1.00 or 100 to fund ¥100, a zero-decimal currency).
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// A description of the test funding. This simulates free-text references supplied by
        /// customers when making bank transfers to their cash balance. You can use this to test how
        /// Stripe's <a
        /// href="https://docs.stripe.com/payments/customer-balance/reconciliation">reconciliation
        /// algorithm</a> applies to different user inputs.
        /// </summary>
        [JsonProperty("reference")]
        [STJS.JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}
