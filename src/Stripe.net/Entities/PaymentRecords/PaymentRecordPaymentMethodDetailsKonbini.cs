// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsKonbini : StripeEntity<PaymentRecordPaymentMethodDetailsKonbini>
    {
        /// <summary>
        /// If the payment succeeded, this contains the details of the convenience store where the
        /// payment was completed.
        /// </summary>
        [JsonProperty("store")]
        [STJS.JsonPropertyName("store")]
        public PaymentRecordPaymentMethodDetailsKonbiniStore Store { get; set; }
    }
}
