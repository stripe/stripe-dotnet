// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentLatestPaymentAttemptRecordDetails : StripeEntity<OffSessionPaymentLatestPaymentAttemptRecordDetails>
    {
        /// <summary>
        /// Details about the failure for the latest payment attempt.
        /// </summary>
        [JsonProperty("failure_details")]
        [STJS.JsonPropertyName("failure_details")]
        public OffSessionPaymentLatestPaymentAttemptRecordDetailsFailureDetails FailureDetails { get; set; }

        /// <summary>
        /// Details about the payment method for the latest payment attempt.
        /// </summary>
        [JsonProperty("payment_method_details")]
        [STJS.JsonPropertyName("payment_method_details")]
        public OffSessionPaymentLatestPaymentAttemptRecordDetailsPaymentMethodDetails PaymentMethodDetails { get; set; }

        /// <summary>
        /// Details about the processor for the latest payment attempt.
        /// </summary>
        [JsonProperty("processor_details")]
        [STJS.JsonPropertyName("processor_details")]
        public OffSessionPaymentLatestPaymentAttemptRecordDetailsProcessorDetails ProcessorDetails { get; set; }
    }
}
