// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a customer's subscription's pending update expires before the related
    /// invoice is paid.
    /// </summary>
    public class PushedV1CustomerSubscriptionPendingUpdateExpiredEvent : V2.PushedEvent
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
        public Task<Subscription> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Subscription>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Subscription FetchRelatedObject()
        {
            return this.FetchRelatedObject<Subscription>(this.RelatedObject);
        }

        public V1CustomerSubscriptionPendingUpdateExpiredEvent Pull()
        {
            return this.PullEvent<V1CustomerSubscriptionPendingUpdateExpiredEvent>();
        }

        public Task<V1CustomerSubscriptionPendingUpdateExpiredEvent> PullAsync()
        {
            return this.PullEventAsync<V1CustomerSubscriptionPendingUpdateExpiredEvent>();
        }
    }
}
