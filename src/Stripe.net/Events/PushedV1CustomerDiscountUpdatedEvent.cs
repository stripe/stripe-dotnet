// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a customer is switched from one coupon to another.
    /// </summary>
    public class PushedV1CustomerDiscountUpdatedEvent : V2.PushedEvent
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Discount> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Discount>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Discount FetchRelatedObject()
        {
            return this.FetchRelatedObject<Discount>(this.RelatedObject);
        }

        public V1CustomerDiscountUpdatedEvent Pull()
        {
            return this.PullEvent<V1CustomerDiscountUpdatedEvent>();
        }

        public Task<V1CustomerDiscountUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CustomerDiscountUpdatedEvent>();
        }
    }
}
