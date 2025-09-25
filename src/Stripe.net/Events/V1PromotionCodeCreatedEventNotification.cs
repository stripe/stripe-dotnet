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
    /// Occurs whenever a promotion code is created.
    /// </summary>
    public class V1PromotionCodeCreatedEventNotification : V2.EventNotification
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
        public Task<PromotionCode> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<PromotionCode>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public PromotionCode FetchRelatedObject()
        {
            return this.FetchRelatedObject<PromotionCode>(this.RelatedObject);
        }

        public V1PromotionCodeCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1PromotionCodeCreatedEvent>();
        }

        public Task<V1PromotionCodeCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PromotionCodeCreatedEvent>();
        }
    }
}
