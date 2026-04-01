// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordFailedProcessorDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Information about the custom processor used to make this payment.
        /// </summary>
        [JsonProperty("custom")]
        [STJS.JsonPropertyName("custom")]
        public PaymentRecordFailedProcessorDetailsCustomOptions Custom { get; set; }

        /// <summary>
        /// The type of the processor details. An additional hash is included on processor_details
        /// with a name matching this value. It contains additional information specific to the
        /// processor.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
