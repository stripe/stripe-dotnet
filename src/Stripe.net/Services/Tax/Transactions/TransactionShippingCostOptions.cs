// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The amount to reverse, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of tax to reverse, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_tax")]
#endif
        public long? AmountTax { get; set; }
    }
}
