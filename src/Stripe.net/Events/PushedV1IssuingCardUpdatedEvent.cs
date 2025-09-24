// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a card is updated.
    /// </summary>
    public class PushedV1IssuingCardUpdatedEvent : V2.PushedEvent
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
        public Task<Issuing.Card> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Card>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Card FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Card>(this.RelatedObject);
        }

        public V1IssuingCardUpdatedEvent Pull()
        {
            return this.PullEvent<V1IssuingCardUpdatedEvent>();
        }

        public Task<V1IssuingCardUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1IssuingCardUpdatedEvent>();
        }
    }
}
