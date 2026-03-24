// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardPresent : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardPresent>
    {
        [JsonProperty("commodity_code")]
        [STJS.JsonPropertyName("commodity_code")]
        public string CommodityCode { get; set; }
    }
}
