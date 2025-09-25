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
    /// Occurs whenever a payout attempt fails.
    /// </summary>
    public class V1PayoutFailedEventNotification : V2.EventNotification
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
        public Task<Payout> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Payout>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Payout FetchRelatedObject()
        {
            return this.FetchRelatedObject<Payout>(this.RelatedObject);
        }

        public V1PayoutFailedEvent FetchEvent()
        {
            return this.FetchEvent<V1PayoutFailedEvent>();
        }

        public Task<V1PayoutFailedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PayoutFailedEvent>();
        }
    }
}
