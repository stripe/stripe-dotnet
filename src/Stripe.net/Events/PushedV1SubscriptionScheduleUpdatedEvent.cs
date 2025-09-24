// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a subscription schedule is updated.
    /// </summary>
    public class PushedV1SubscriptionScheduleUpdatedEvent : V2.PushedEvent
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
        public Task<SubscriptionSchedule> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<SubscriptionSchedule>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public SubscriptionSchedule FetchRelatedObject()
        {
            return this.FetchRelatedObject<SubscriptionSchedule>(this.RelatedObject);
        }

        public V1SubscriptionScheduleUpdatedEvent Pull()
        {
            return this.PullEvent<V1SubscriptionScheduleUpdatedEvent>();
        }

        public Task<V1SubscriptionScheduleUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1SubscriptionScheduleUpdatedEvent>();
        }
    }
}
