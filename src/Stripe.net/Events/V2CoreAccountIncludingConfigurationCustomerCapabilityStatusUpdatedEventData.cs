// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountIncludingConfigurationCustomerCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// </summary>
        [JsonProperty("updated_capability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_capability")]
#endif
        public string UpdatedCapability { get; set; }
    }
}
