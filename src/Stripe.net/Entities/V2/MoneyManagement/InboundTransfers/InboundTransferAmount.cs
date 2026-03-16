// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferAmount : StripeEntity<InboundTransferAmount>
    {
        /// <summary>
        /// A non-negative integer representing how much to charge in the <a
        /// href="https://docs.stripe.com/currencies#minor-units">smallest currency unit</a>.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public long Value { get; set; }

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
    }
}
