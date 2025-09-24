// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a payout attempt fails.
    /// </summary>
    public class PushedV1PayoutFailedEvent : V2.PushedEvent
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

        public V1PayoutFailedEvent Pull()
        {
            return this.PullEvent<V1PayoutFailedEvent>();
        }

        public Task<V1PayoutFailedEvent> PullAsync()
        {
            return this.PullEventAsync<V1PayoutFailedEvent>();
        }
    }
}
