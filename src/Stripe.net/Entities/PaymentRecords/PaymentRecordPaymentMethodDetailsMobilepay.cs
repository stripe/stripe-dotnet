// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordPaymentMethodDetailsMobilepay : StripeEntity<PaymentRecordPaymentMethodDetailsMobilepay>
    {
        /// <summary>
        /// Internal card details.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentRecordPaymentMethodDetailsMobilepayCard Card { get; set; }
    }
}
