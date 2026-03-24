// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Occurs when a RateCardRate is created.
    /// </summary>
    public class V2BillingRateCardRateCreatedEventNotification : V2.Core.EventNotification
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


        public Task<V2.Billing.RateCardRate> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Billing.RateCardRate>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>


        public V2.Billing.RateCardRate FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Billing.RateCardRate>(this.RelatedObject);
        }

        public V2BillingRateCardRateCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2BillingRateCardRateCreatedEvent>();
        }

        public Task<V2BillingRateCardRateCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2BillingRateCardRateCreatedEvent>();
        }
    }
}
