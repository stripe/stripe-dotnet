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
    /// Occurs whenever a transfer is created.
    /// </summary>
    public class V1TransferCreatedEventNotification : V2.Core.EventNotification
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

        public V1TransferCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1TransferCreatedEvent>();
        }

        public Task<V1TransferCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1TransferCreatedEvent>();
        }
    }
}
