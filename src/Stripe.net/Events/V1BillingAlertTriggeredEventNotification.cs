// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever your custom alert threshold is met.
    /// </summary>
    public class V1BillingAlertTriggeredEventNotification : V2.Core.EventNotification
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
        public Task<Billing.Alert> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Billing.Alert>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Billing.Alert FetchRelatedObject()
        {
            return this.FetchRelatedObject<Billing.Alert>(this.RelatedObject);
        }

        public V1BillingAlertTriggeredEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingAlertTriggeredEvent>();
        }

        public Task<V1BillingAlertTriggeredEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingAlertTriggeredEvent>();
        }
    }
}
