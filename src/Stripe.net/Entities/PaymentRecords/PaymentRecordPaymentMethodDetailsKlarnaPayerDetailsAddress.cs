// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsKlarnaPayerDetailsAddress : StripeEntity<PaymentRecordPaymentMethodDetailsKlarnaPayerDetailsAddress>
    {
        /// <summary>
        /// The payer address country.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
