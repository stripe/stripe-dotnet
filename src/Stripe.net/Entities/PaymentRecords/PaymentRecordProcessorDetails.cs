// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentRecordProcessorDetails : StripeEntity<PaymentRecordProcessorDetails>
    {
        /// <summary>
        /// Custom processors represent payment processors not modeled directly in the Stripe API.
        /// This resource consists of details about the custom processor used for this payment
        /// attempt.
        /// </summary>
        [JsonProperty("custom")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom")]
#endif
        public PaymentRecordProcessorDetailsCustom Custom { get; set; }

        /// <summary>
        /// The processor used for this payment attempt.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
