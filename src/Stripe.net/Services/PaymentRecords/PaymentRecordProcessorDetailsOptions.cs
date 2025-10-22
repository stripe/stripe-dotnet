// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordProcessorDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Information about the custom processor used to make this payment.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public PaymentRecordProcessorDetailsCustomOptions Custom { get; set; }

        /// <summary>
        /// The type of the processor details. An additional hash is included on processor_details
        /// with a name matching this value. It contains additional information specific to the
        /// processor.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
