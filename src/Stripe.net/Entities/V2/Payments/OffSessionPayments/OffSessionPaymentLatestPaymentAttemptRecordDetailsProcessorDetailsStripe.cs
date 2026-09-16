// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentLatestPaymentAttemptRecordDetailsProcessorDetailsStripe : StripeEntity<OffSessionPaymentLatestPaymentAttemptRecordDetailsProcessorDetailsStripe>
    {
        /// <summary>
        /// ID of the Charge created for the latest payment attempt.
        /// </summary>
        [JsonProperty("charge")]
        [STJS.JsonPropertyName("charge")]
        public string Charge { get; set; }
    }
}
