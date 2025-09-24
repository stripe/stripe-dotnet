// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a customer is deleted.
    /// </summary>
    public class PushedV1CustomerDeletedEvent : V2.PushedEvent
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
        public Task<Customer> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Customer>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Customer FetchRelatedObject()
        {
            return this.FetchRelatedObject<Customer>(this.RelatedObject);
        }

        public V1CustomerDeletedEvent Pull()
        {
            return this.PullEvent<V1CustomerDeletedEvent>();
        }

        public Task<V1CustomerDeletedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CustomerDeletedEvent>();
        }
    }
}
