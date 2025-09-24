// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a payout is updated.
    /// </summary>
    public class PushedV1PayoutUpdatedEvent : V2.PushedEvent
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
        public Task<Payout> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Payout>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Payout FetchRelatedObject()
        {
            return this.FetchRelatedObject<Payout>(this.RelatedObject);
        }

        public V1PayoutUpdatedEvent Pull()
        {
            return this.PullEvent<V1PayoutUpdatedEvent>();
        }

        public Task<V1PayoutUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1PayoutUpdatedEvent>();
        }
    }
}
