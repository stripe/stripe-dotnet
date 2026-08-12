// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs three days before a subscription's trial period is scheduled to end, or
    /// immediately when a trial is ended early (for example, with <c>trial_end=now</c> or when
    /// a Customer Portal plan change ends a trial). If a trial is shortened so that fewer than
    /// three days remain, this event can fire immediately, including during the same
    /// transaction that collects payment. Before sending payment-reminder communications from
    /// this webhook, check the subscription status and latest invoice to determine whether
    /// payment has already been collected.
    /// </summary>
    public class V1CustomerSubscriptionTrialWillEndEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

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

        public V1CustomerSubscriptionTrialWillEndEvent FetchEvent()
        {
            return this.FetchEvent<V1CustomerSubscriptionTrialWillEndEvent>();
        }

        public Task<V1CustomerSubscriptionTrialWillEndEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CustomerSubscriptionTrialWillEndEvent>();
        }
    }
}
