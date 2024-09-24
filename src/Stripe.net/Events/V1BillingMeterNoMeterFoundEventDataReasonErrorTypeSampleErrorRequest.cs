// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    public class V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleErrorRequest : StripeEntity<V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleErrorRequest>
    {
        /// <summary>
        /// The request idempotency key.
        /// </summary>
        [JsonProperty("identifier")]
        public string Identifier { get; set; }
    }
}
