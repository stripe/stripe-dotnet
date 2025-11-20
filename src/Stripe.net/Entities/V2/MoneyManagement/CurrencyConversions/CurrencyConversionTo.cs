// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CurrencyConversionTo : StripeEntity<CurrencyConversionTo>
    {
        /// <summary>
        /// Amount object.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public CurrencyConversionToAmount Amount { get; set; }
    }
}
