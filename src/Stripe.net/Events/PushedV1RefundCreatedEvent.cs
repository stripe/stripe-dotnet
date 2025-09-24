// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a refund is created.
    /// </summary>
    public class PushedV1RefundCreatedEvent : V2.PushedEvent
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
        public Task<Refund> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Refund>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Refund FetchRelatedObject()
        {
            return this.FetchRelatedObject<Refund>(this.RelatedObject);
        }

        public V1RefundCreatedEvent Pull()
        {
            return this.PullEvent<V1RefundCreatedEvent>();
        }

        public Task<V1RefundCreatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1RefundCreatedEvent>();
        }
    }
}
