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
    /// Occurs whenever a card is created.
    /// </summary>
    public class V1IssuingCardCreatedEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

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

        public V1IssuingCardCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingCardCreatedEvent>();
        }

        public Task<V1IssuingCardCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingCardCreatedEvent>();
        }
    }
}
