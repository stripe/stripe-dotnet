// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    public class V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// </summary>
        [JsonProperty("updated_capability")]
        [STJS.JsonPropertyName("updated_capability")]
        public string UpdatedCapability { get; set; }
    }
}
