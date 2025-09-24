// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a review is opened.
    /// </summary>
    public class PushedV1ReviewOpenedEvent : V2.PushedEvent
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
        public Task<Review> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Review>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Review FetchRelatedObject()
        {
            return this.FetchRelatedObject<Review>(this.RelatedObject);
        }

        public V1ReviewOpenedEvent Pull()
        {
            return this.PullEvent<V1ReviewOpenedEvent>();
        }

        public Task<V1ReviewOpenedEvent> PullAsync()
        {
            return this.PullEventAsync<V1ReviewOpenedEvent>();
        }
    }
}
