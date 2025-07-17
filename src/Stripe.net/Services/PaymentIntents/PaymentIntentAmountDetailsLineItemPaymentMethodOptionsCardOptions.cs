// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardOptions : INestedOptions
    {
        /// <summary>
        /// Identifier that categorizes the items being purchased using a standardized commodity
        /// scheme such as (but not limited to) UNSPSC, NAICS, NAPCS, etc.
        /// </summary>
        [JsonProperty("commodity_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("commodity_code")]
#endif
        public string CommodityCode { get; set; }
    }
}
