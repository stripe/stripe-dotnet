// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsFleetDatumPrimaryFuelFields : StripeEntity<PaymentIntentPaymentDetailsFleetDatumPrimaryFuelFields>
    {
        /// <summary>
        /// The fuel brand.
        /// </summary>
        [JsonProperty("brand")]
        [STJS.JsonPropertyName("brand")]
        public string Brand { get; set; }
    }
}
