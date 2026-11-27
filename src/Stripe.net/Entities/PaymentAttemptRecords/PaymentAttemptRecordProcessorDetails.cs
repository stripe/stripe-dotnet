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
        /// Represents the Stripe processor. This resource consists of details specific to Stripe.
        /// </summary>
        [JsonProperty("stripe")]
        [STJS.JsonPropertyName("stripe")]
        public PaymentAttemptRecordProcessorDetailsStripe Stripe { get; set; }

        /// <summary>
        /// The processor used for this payment attempt.
        /// One of: <c>custom</c>, or <c>stripe</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
