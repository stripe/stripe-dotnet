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
    /// Occurs whenever an account status or property has changed.
    /// </summary>
    public class V1AccountUpdatedEventNotification : V2.EventNotification
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
        public Task<Account> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Account>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Account FetchRelatedObject()
        {
            return this.FetchRelatedObject<Account>(this.RelatedObject);
        }

        public V1AccountUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountUpdatedEvent>();
        }

        public Task<V1AccountUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountUpdatedEvent>();
        }
    }
}
