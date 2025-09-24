// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a coupon is deleted.
    /// </summary>
    public class PushedV1CouponDeletedEvent : V2.PushedEvent
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
        public Task<Coupon> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Coupon>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Coupon FetchRelatedObject()
        {
            return this.FetchRelatedObject<Coupon>(this.RelatedObject);
        }

        public V1CouponDeletedEvent Pull()
        {
            return this.PullEvent<V1CouponDeletedEvent>();
        }

        public Task<V1CouponDeletedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CouponDeletedEvent>();
        }
    }
}
