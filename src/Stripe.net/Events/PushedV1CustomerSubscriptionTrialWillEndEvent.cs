// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs three days before a subscription's trial period is scheduled to end, or when a
    /// trial is ended immediately (using <c>trial_end=now</c>).
    /// </summary>
    public class PushedV1CustomerSubscriptionTrialWillEndEvent : V2.PushedEvent
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

        public V1CustomerSubscriptionTrialWillEndEvent Pull()
        {
            return this.PullEvent<V1CustomerSubscriptionTrialWillEndEvent>();
        }

        public Task<V1CustomerSubscriptionTrialWillEndEvent> PullAsync()
        {
            return this.PullEventAsync<V1CustomerSubscriptionTrialWillEndEvent>();
        }
    }
}
