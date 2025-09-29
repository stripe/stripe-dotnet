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
    /// Occurs whenever a charge is refunded, including partial refunds. Listen to
    /// <c>refund.created</c> for information about the refund.
    /// </summary>
    public class V1ChargeRefundedEventNotification : V2.Core.EventNotification
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
        public Task<Charge> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Charge>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Charge FetchRelatedObject()
        {
            return this.FetchRelatedObject<Charge>(this.RelatedObject);
        }

        public V1ChargeRefundedEvent FetchEvent()
        {
            return this.FetchEvent<V1ChargeRefundedEvent>();
        }

        public Task<V1ChargeRefundedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1ChargeRefundedEvent>();
        }
    }
}
