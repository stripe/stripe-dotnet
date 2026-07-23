// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCard : StripeEntity<PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCard>
    {
        [JsonProperty("commodity_code")]
        [STJS.JsonPropertyName("commodity_code")]
        public string CommodityCode { get; set; }

        [JsonProperty("ev_charging")]
        [STJS.JsonPropertyName("ev_charging")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardEvCharging EvCharging { get; set; }

        [JsonProperty("fleet_data")]
        [STJS.JsonPropertyName("fleet_data")]
        public PaymentIntentAmountDetailsLineItemPaymentMethodOptionsCardFleetData FleetData { get; set; }
    }
}
