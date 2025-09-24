// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a Climate order's product is substituted for another.
    /// </summary>
    public class PushedV1ClimateOrderProductSubstitutedEvent : V2.PushedEvent
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Climate.Order> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Climate.Order>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Climate.Order FetchRelatedObject()
        {
            return this.FetchRelatedObject<Climate.Order>(this.RelatedObject);
        }

        public V1ClimateOrderProductSubstitutedEvent Pull()
        {
            return this.PullEvent<V1ClimateOrderProductSubstitutedEvent>();
        }

        public Task<V1ClimateOrderProductSubstitutedEvent> PullAsync()
        {
            return this.PullEventAsync<V1ClimateOrderProductSubstitutedEvent>();
        }
    }
}
