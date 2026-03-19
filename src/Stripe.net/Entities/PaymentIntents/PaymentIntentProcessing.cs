// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentProcessing : StripeEntity<PaymentIntentProcessing>
    {
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public PaymentIntentProcessingCard Card { get; set; }

        /// <summary>
        /// Type of the payment method for which payment is in <c>processing</c> state, one of
        /// <c>card</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
