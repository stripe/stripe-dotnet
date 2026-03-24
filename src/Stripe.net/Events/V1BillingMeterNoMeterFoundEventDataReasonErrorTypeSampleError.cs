// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleError : StripeEntity<V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleError>
    {
        /// <summary>
        /// The error message.
        /// </summary>
        [JsonProperty("error_message")]
        [STJS.JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The request causes the error.
        /// </summary>
        [JsonProperty("request")]
        [STJS.JsonPropertyName("request")]
        public V1BillingMeterNoMeterFoundEventDataReasonErrorTypeSampleErrorRequest Request { get; set; }
    }
}
