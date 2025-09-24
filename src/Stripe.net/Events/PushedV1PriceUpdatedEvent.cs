// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a price is updated.
    /// </summary>
    public class PushedV1PriceUpdatedEvent : V2.PushedEvent
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
        public Task<Price> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Price>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Price FetchRelatedObject()
        {
            return this.FetchRelatedObject<Price>(this.RelatedObject);
        }

        public V1PriceUpdatedEvent Pull()
        {
            return this.PullEvent<V1PriceUpdatedEvent>();
        }

        public Task<V1PriceUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1PriceUpdatedEvent>();
        }
    }
}
