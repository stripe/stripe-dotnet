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
    /// Occurs whenever a top-up is canceled.
    /// </summary>
    public class V1TopupCanceledEventNotification : V2.EventNotification
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
        public Task<Topup> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Topup>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Topup FetchRelatedObject()
        {
            return this.FetchRelatedObject<Topup>(this.RelatedObject);
        }

        public V1TopupCanceledEvent FetchEvent()
        {
            return this.FetchEvent<V1TopupCanceledEvent>();
        }

        public Task<V1TopupCanceledEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1TopupCanceledEvent>();
        }
    }
}
