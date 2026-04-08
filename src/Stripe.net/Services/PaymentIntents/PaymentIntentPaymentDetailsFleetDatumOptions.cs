// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsFleetDatumOptions : INestedOptions
    {
        /// <summary>
        /// Primary fuel fields for the transaction.
        /// </summary>
        [JsonProperty("primary_fuel_fields")]
        [STJS.JsonPropertyName("primary_fuel_fields")]
        public PaymentIntentPaymentDetailsFleetDatumPrimaryFuelFieldsOptions PrimaryFuelFields { get; set; }

        /// <summary>
        /// Station and acceptor location details.
        /// </summary>
        [JsonProperty("station")]
        [STJS.JsonPropertyName("station")]
        public PaymentIntentPaymentDetailsFleetDatumStationOptions Station { get; set; }

        /// <summary>
        /// VAT and Invoice on Behalf (IOB) details.
        /// </summary>
        [JsonProperty("vat")]
        [STJS.JsonPropertyName("vat")]
        public PaymentIntentPaymentDetailsFleetDatumVatOptions Vat { get; set; }
    }
}
