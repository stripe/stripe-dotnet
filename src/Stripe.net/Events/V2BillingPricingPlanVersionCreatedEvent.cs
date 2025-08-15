// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a PricingPlanVersion is created.
    /// </summary>
    public class V2BillingPricingPlanVersionCreatedEvent : V2.Event
    {
        /// <summary>
        /// Data for the v2.billing.pricing_plan_version.created event.
        /// </summary>
        [JsonProperty("data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("data")]
#endif

        public V2BillingPricingPlanVersionCreatedEventData Data { get; set; }

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
        public Task<V2.Billing.PricingPlanVersion> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.PricingPlanVersion>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.PricingPlanVersion FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.PricingPlanVersion>(this.RelatedObject);
        }
    }
}
