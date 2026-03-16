// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CurrencyConversionFrom : StripeEntity<CurrencyConversionFrom>
    {
        /// <summary>
        /// Amount object.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public CurrencyConversionFromAmount Amount { get; set; }
    }
}
