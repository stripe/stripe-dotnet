// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardPresentOptions : INestedOptions
    {
        /// <summary>
        /// Identifier that categorizes the items being purchased using a standardized commodity
        /// scheme such as (but not limited to) UNSPSC, NAICS, NAPCS, and so on.
        /// </summary>
        [JsonProperty("commodity_code")]
        [STJS.JsonPropertyName("commodity_code")]
        public string CommodityCode { get; set; }
    }
}
