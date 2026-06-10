// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentRecordProcessorDetails : StripeEntity<PaymentRecordProcessorDetails>
    {
        /// <summary>
        /// Custom processors represent payment processors not modeled directly in the Stripe API.
        /// This resource consists of details about the custom processor used for this payment
        /// attempt.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentRecordProcessorDetailsCustom Custom { get; set; }

        /// <summary>
        /// Represents the Fiserv ValueLink gift card processor.
        /// </summary>
        [JsonProperty("fiserv_valuelink")]
        [STJS.JsonPropertyName("fiserv_valuelink")]
        public PaymentRecordProcessorDetailsFiservValuelink FiservValuelink { get; set; }

        /// <summary>
        /// Represents the Givex gift card processor.
        /// </summary>
        [JsonProperty("givex")]
        [STJS.JsonPropertyName("givex")]
        public PaymentRecordProcessorDetailsGivex Givex { get; set; }

        /// <summary>
        /// Represents the SVS gift card processor.
        /// </summary>
        [JsonProperty("svs")]
        [STJS.JsonPropertyName("svs")]
        public PaymentRecordProcessorDetailsSvs Svs { get; set; }

        /// <summary>
        /// The processor used for this payment attempt.
        /// One of: <c>custom</c>, <c>fiserv_valuelink</c>, <c>givex</c>, or <c>svs</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
