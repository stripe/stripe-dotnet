// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentProcessing : StripeEntity<PaymentIntentProcessing>
    {
        [JsonProperty("card")]
        public PaymentIntentProcessingCard Card { get; set; }

        /// <summary>
        /// Type of the next action to perform, one of <c>card</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
