// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFleetDatum : StripeEntity<PaymentIntentPaymentDetailsFleetDatum>
    {
        [JsonProperty("primary_fuel_fields")]
        [STJS.JsonPropertyName("primary_fuel_fields")]
        public PaymentIntentPaymentDetailsFleetDatumPrimaryFuelFields PrimaryFuelFields { get; set; }

        [JsonProperty("station")]
        [STJS.JsonPropertyName("station")]
        public PaymentIntentPaymentDetailsFleetDatumStation Station { get; set; }

        [JsonProperty("vat")]
        [STJS.JsonPropertyName("vat")]
        public PaymentIntentPaymentDetailsFleetDatumVat Vat { get; set; }
    }
}
