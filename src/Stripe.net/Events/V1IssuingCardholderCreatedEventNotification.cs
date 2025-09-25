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
    /// Occurs whenever a cardholder is created.
    /// </summary>
    public class V1IssuingCardholderCreatedEventNotification : V2.EventNotification
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
        public Task<Issuing.Cardholder> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Cardholder>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Cardholder FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Cardholder>(this.RelatedObject);
        }

        public V1IssuingCardholderCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingCardholderCreatedEvent>();
        }

        public Task<V1IssuingCardholderCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingCardholderCreatedEvent>();
        }
    }
}
