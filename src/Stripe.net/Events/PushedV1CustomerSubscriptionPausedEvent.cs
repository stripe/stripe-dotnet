// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a customer's subscription is paused. Only applies when subscriptions
    /// enter <c>status=paused</c>, not when <a
    /// href="https://docs.stripe.com/billing/subscriptions/pause">payment collection</a> is
    /// paused.
    /// </summary>
    public class PushedV1CustomerSubscriptionPausedEvent : V2.PushedEvent
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

        public V1CustomerSubscriptionPausedEvent Pull()
        {
            return this.PullEvent<V1CustomerSubscriptionPausedEvent>();
        }

        public Task<V1CustomerSubscriptionPausedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CustomerSubscriptionPausedEvent>();
        }
    }
}
