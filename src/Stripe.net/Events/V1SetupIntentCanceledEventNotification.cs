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
    /// Occurs when a SetupIntent is canceled.
    /// </summary>
    public class V1SetupIntentCanceledEventNotification : V2.EventNotification
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
        public Task<SetupIntent> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<SetupIntent>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public SetupIntent FetchRelatedObject()
        {
            return this.FetchRelatedObject<SetupIntent>(this.RelatedObject);
        }

        public V1SetupIntentCanceledEvent FetchEvent()
        {
            return this.FetchEvent<V1SetupIntentCanceledEvent>();
        }

        public Task<V1SetupIntentCanceledEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1SetupIntentCanceledEvent>();
        }
    }
}
