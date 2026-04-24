// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs whenever your custom alert threshold is met.
    /// </summary>
    public class V1BillingAlertTriggeredEvent : V2.Core.Event
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
        [STJS.JsonPropertyName("related_object")]

        public V2.Core.EventRelatedObject RelatedObject { get; set; }

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
    }
}
