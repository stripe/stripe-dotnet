// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CurrencyConversionCreateFromOptions : INestedOptions
    {
        /// <summary>
        /// Amount object.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public CurrencyConversionCreateFromAmountOptions Amount { get; set; }

        /// <summary>
        /// A lowercase alpha3 currency code like "usd".
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }
    }
}
