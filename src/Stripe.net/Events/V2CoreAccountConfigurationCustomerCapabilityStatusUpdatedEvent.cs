// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The status of a customer config capability was updated.
    /// </summary>
    public class V2CoreAccountConfigurationCustomerCapabilityStatusUpdatedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.core.account[configuration.customer].capability_status_updated event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2CoreAccountConfigurationCustomerCapabilityStatusUpdatedEventData Data { get; set; }
    }
}
