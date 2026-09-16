// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentLatestPaymentAttemptRecordDetailsProcessorDetails : StripeEntity<OffSessionPaymentLatestPaymentAttemptRecordDetailsProcessorDetails>
    {
        /// <summary>
        /// Details about Stripe as the processor.
        /// </summary>
        [JsonProperty("stripe")]
        [STJS.JsonPropertyName("stripe")]
        public OffSessionPaymentLatestPaymentAttemptRecordDetailsProcessorDetailsStripe Stripe { get; set; }
    }
}
