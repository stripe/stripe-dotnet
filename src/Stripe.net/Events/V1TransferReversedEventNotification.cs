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
    /// Occurs whenever a transfer is reversed, including partial reversals.
    /// </summary>
    public class V1TransferReversedEventNotification : V2.Core.EventNotification
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
        public Task<Transfer> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Transfer>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Transfer FetchRelatedObject()
        {
            return this.FetchRelatedObject<Transfer>(this.RelatedObject);
        }

        public V1TransferReversedEvent FetchEvent()
        {
            return this.FetchEvent<V1TransferReversedEvent>();
        }

        public Task<V1TransferReversedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1TransferReversedEvent>();
        }
    }
}
