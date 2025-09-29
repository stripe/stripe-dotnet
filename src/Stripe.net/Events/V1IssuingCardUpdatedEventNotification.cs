// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a card is updated.
    /// </summary>
    public class V1IssuingCardUpdatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V1IssuingCardUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingCardUpdatedEvent>();
        }

        public Task<V1IssuingCardUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingCardUpdatedEvent>();
        }
    }
}
