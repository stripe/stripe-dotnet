// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever an issuing digital wallet token is updated.
    /// </summary>
    public class PushedV1IssuingTokenUpdatedEvent : V2.PushedEvent
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
        public Task<Issuing.Token> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Token>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Token FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Token>(this.RelatedObject);
        }

        public V1IssuingTokenUpdatedEvent Pull()
        {
            return this.PullEvent<V1IssuingTokenUpdatedEvent>();
        }

        public Task<V1IssuingTokenUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1IssuingTokenUpdatedEvent>();
        }
    }
}
