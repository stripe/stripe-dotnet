// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs X number of days after an invoice becomes due—where X is determined by
    /// Automations.
    /// </summary>
    public class V1InvoiceOverdueEvent : V2.Core.Event
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
        public Task<Invoice> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Invoice>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Invoice FetchRelatedObject()
        {
            return this.FetchRelatedObject<Invoice>(this.RelatedObject);
        }
    }
}
