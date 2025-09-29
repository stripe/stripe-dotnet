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
    /// Occurs whenever a customer's subscription is no longer paused. Only applies when a
    /// <c>status=paused</c> subscription is <a
    /// href="https://docs.stripe.com/api/subscriptions/resume">resumed</a>, not when <a
    /// href="https://docs.stripe.com/billing/subscriptions/pause">payment collection</a> is
    /// resumed.
    /// </summary>
    public class V1CustomerSubscriptionResumedEventNotification : V2.Core.EventNotification
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

        public V1CustomerSubscriptionResumedEvent FetchEvent()
        {
            return this.FetchEvent<V1CustomerSubscriptionResumedEvent>();
        }

        public Task<V1CustomerSubscriptionResumedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CustomerSubscriptionResumedEvent>();
        }
    }
}
