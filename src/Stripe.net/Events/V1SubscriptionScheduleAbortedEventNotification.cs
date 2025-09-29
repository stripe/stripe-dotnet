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
    /// Occurs whenever a subscription schedule is canceled due to the underlying subscription
    /// being canceled because of delinquency.
    /// </summary>
    public class V1SubscriptionScheduleAbortedEventNotification : V2.Core.EventNotification
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

        public V1SubscriptionScheduleAbortedEvent FetchEvent()
        {
            return this.FetchEvent<V1SubscriptionScheduleAbortedEvent>();
        }

        public Task<V1SubscriptionScheduleAbortedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1SubscriptionScheduleAbortedEvent>();
        }
    }
}
