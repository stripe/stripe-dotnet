// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a RateCardCustomPricingUnitOverageRate is created.
    /// </summary>
    public class V2BillingRateCardCustomPricingUnitOverageRateCreatedEventNotification : V2.Core.EventNotification
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
        public Task<V2.Billing.RateCardCustomPricingUnitOverageRate> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.RateCardCustomPricingUnitOverageRate>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Billing.RateCardCustomPricingUnitOverageRate FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.RateCardCustomPricingUnitOverageRate>(this.RelatedObject);
        }

        public V2BillingRateCardCustomPricingUnitOverageRateCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2BillingRateCardCustomPricingUnitOverageRateCreatedEvent>();
        }

        public Task<V2BillingRateCardCustomPricingUnitOverageRateCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2BillingRateCardCustomPricingUnitOverageRateCreatedEvent>();
        }
    }
}
