// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a RateCardVersion is created.
    /// </summary>
    public class PushedV2BillingRateCardVersionCreatedEvent : V2.PushedEvent
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
        public Task<V2.Billing.RateCardVersion> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.RateCardVersion>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.RateCardVersion FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.RateCardVersion>(this.RelatedObject);
        }

        public V2BillingRateCardVersionCreatedEvent Pull()
        {
            return this.PullEvent<V2BillingRateCardVersionCreatedEvent>();
        }

        public Task<V2BillingRateCardVersionCreatedEvent> PullAsync()
        {
            return this.PullEventAsync<V2BillingRateCardVersionCreatedEvent>();
        }
    }
}
