// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a meter is created.
    /// </summary>
    public class V1BillingMeterCreatedEventNotification : V2.Core.EventNotification
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
        public Task<Billing.Meter> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Billing.Meter>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Billing.Meter FetchRelatedObject()
        {
            return this.FetchRelatedObject<Billing.Meter>(this.RelatedObject);
        }

        public V1BillingMeterCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingMeterCreatedEvent>();
        }

        public Task<V1BillingMeterCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingMeterCreatedEvent>();
        }
    }
}
