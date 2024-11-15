// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleErrorRequest : StripeEntity<V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleErrorRequest>
    {
        /// <summary>
        /// The request idempotency key.
        /// </summary>
        [JsonProperty("identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identifier")]
#endif

        public string Identifier { get; set; }
    }
}
