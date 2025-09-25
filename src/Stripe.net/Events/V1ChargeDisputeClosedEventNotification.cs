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
    /// Occurs when a dispute is closed and the dispute status changes to <c>lost</c>,
    /// <c>warning_closed</c>, or <c>won</c>.
    /// </summary>
    public class V1ChargeDisputeClosedEventNotification : V2.EventNotification
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
        public Task<Dispute> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Dispute>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Dispute FetchRelatedObject()
        {
            return this.FetchRelatedObject<Dispute>(this.RelatedObject);
        }

        public V1ChargeDisputeClosedEvent FetchEvent()
        {
            return this.FetchEvent<V1ChargeDisputeClosedEvent>();
        }

        public Task<V1ChargeDisputeClosedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1ChargeDisputeClosedEvent>();
        }
    }
}
