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
    /// Occurs whenever an action sent to a Terminal reader failed.
    /// </summary>
    public class V1TerminalReaderActionFailedEventNotification : V2.Core.EventNotification
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
        public Task<Terminal.Reader> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Terminal.Reader>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Terminal.Reader FetchRelatedObject()
        {
            return this.FetchRelatedObject<Terminal.Reader>(this.RelatedObject);
        }

        public V1TerminalReaderActionFailedEvent FetchEvent()
        {
            return this.FetchEvent<V1TerminalReaderActionFailedEvent>();
        }

        public Task<V1TerminalReaderActionFailedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1TerminalReaderActionFailedEvent>();
        }
    }
}
