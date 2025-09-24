// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a product is deleted.
    /// </summary>
    public class PushedV1ProductDeletedEvent : V2.PushedEvent
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
        public Task<Product> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Product>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Product FetchRelatedObject()
        {
            return this.FetchRelatedObject<Product>(this.RelatedObject);
        }

        public V1ProductDeletedEvent Pull()
        {
            return this.PullEvent<V1ProductDeletedEvent>();
        }

        public Task<V1ProductDeletedEvent> PullAsync()
        {
            return this.PullEventAsync<V1ProductDeletedEvent>();
        }
    }
}
