// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a MeteredItem is created.
    /// </summary>
    public class PushedV2BillingMeteredItemCreatedEvent : V2.PushedEvent
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
        public Task<V2.Billing.MeteredItem> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.MeteredItem>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.MeteredItem FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.MeteredItem>(this.RelatedObject);
        }

        public V2BillingMeteredItemCreatedEvent Pull()
        {
            return this.PullEvent<V2BillingMeteredItemCreatedEvent>();
        }

        public Task<V2BillingMeteredItemCreatedEvent> PullAsync()
        {
            return this.PullEventAsync<V2BillingMeteredItemCreatedEvent>();
        }
    }
}
