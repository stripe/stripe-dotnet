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
    /// Occurs when a PricingPlan is updated.
    /// </summary>
    public class V2BillingPricingPlanUpdatedEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<V2.Billing.PricingPlan> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.PricingPlan>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.PricingPlan FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.PricingPlan>(this.RelatedObject);
        }

        public V2BillingPricingPlanUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V2BillingPricingPlanUpdatedEvent>();
        }

        public Task<V2BillingPricingPlanUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2BillingPricingPlanUpdatedEvent>();
        }
    }
}
