// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordProcessorDetails : StripeEntity<PaymentAttemptRecordProcessorDetails>
    {
        /// <summary>
        /// Custom processors represent payment processors not modeled directly in the Stripe API.
        /// This resource consists of details about the custom processor used for this payment
        /// attempt.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentAttemptRecordProcessorDetailsCustom Custom { get; set; }

        /// <summary>
        /// The processor used for this payment attempt.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
