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
    /// Occurs whenever a dispute is won, lost or expired.
    /// </summary>
    public class V1IssuingDisputeClosedEventNotification : V2.EventNotification
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
        public Task<Issuing.Dispute> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Dispute>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Dispute FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Dispute>(this.RelatedObject);
        }

        public V1IssuingDisputeClosedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingDisputeClosedEvent>();
        }

        public Task<V1IssuingDisputeClosedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingDisputeClosedEvent>();
        }
    }
}
