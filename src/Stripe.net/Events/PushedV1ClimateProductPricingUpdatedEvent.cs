// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a Climate product is updated.
    /// </summary>
    public class PushedV1ClimateProductPricingUpdatedEvent : V2.PushedEvent
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
        public Task<Climate.Product> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Climate.Product>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Climate.Product FetchRelatedObject()
        {
            return this.FetchRelatedObject<Climate.Product>(this.RelatedObject);
        }

        public V1ClimateProductPricingUpdatedEvent Pull()
        {
            return this.PullEvent<V1ClimateProductPricingUpdatedEvent>();
        }

        public Task<V1ClimateProductPricingUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1ClimateProductPricingUpdatedEvent>();
        }
    }
}
