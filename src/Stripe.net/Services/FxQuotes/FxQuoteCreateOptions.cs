// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteCreateOptions : BaseOptions
    {
        /// <summary>
        /// A list of three letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO
        /// currency code</a>, in lowercase. Must be <a
        /// href="https://stripe.com/docs/currencies">supported currencies</a>.
        /// </summary>
        [JsonProperty("from_currencies")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("from_currencies")]
#endif
        public List<string> FromCurrencies { get; set; }

        /// <summary>
        /// The duration that you wish the quote to be locked for. The quote will be usable for the
        /// duration specified. The default is <c>none</c>. The maximum is 1 day.
        /// One of: <c>day</c>, <c>five_minutes</c>, <c>hour</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("lock_duration")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lock_duration")]
#endif
        public string LockDuration { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("to_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("to_currency")]
#endif
        public string ToCurrency { get; set; }

        /// <summary>
        /// The usage specific information for the quote.
        /// </summary>
        [JsonProperty("usage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage")]
#endif
        public FxQuoteUsageOptions Usage { get; set; }
    }
}
