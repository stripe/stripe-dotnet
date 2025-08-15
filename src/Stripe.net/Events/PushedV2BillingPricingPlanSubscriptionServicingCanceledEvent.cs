// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when PricingPlanSubscription servicing is canceled.
    /// </summary>
    public class PushedV2BillingPricingPlanSubscriptionServicingCanceledEvent : V2.PushedEvent
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
        public Task<V2.Billing.PricingPlanSubscription> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.PricingPlanSubscription>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.PricingPlanSubscription FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.PricingPlanSubscription>(this.RelatedObject);
        }

        public V2BillingPricingPlanSubscriptionServicingCanceledEvent Pull()
        {
            return this.PullEvent<V2BillingPricingPlanSubscriptionServicingCanceledEvent>();
        }

        public Task<V2BillingPricingPlanSubscriptionServicingCanceledEvent> PullAsync()
        {
            return this.PullEventAsync<V2BillingPricingPlanSubscriptionServicingCanceledEvent>();
        }
    }
}
