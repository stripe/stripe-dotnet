// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleErrorRequest : StripeEntity<V1BillingMeterErrorReportTriggeredEventDataReasonErrorTypeSampleErrorRequest>
    {
        /// <summary>
        /// The request idempotency key.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}
