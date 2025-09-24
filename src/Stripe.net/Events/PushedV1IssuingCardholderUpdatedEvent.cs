// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a cardholder is updated.
    /// </summary>
    public class PushedV1IssuingCardholderUpdatedEvent : V2.PushedEvent
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

        public V1IssuingCardholderUpdatedEvent Pull()
        {
            return this.PullEvent<V1IssuingCardholderUpdatedEvent>();
        }

        public Task<V1IssuingCardholderUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1IssuingCardholderUpdatedEvent>();
        }
    }
}
