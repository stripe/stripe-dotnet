// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a tax ID is deleted from a customer.
    /// </summary>
    public class PushedV1CustomerTaxIdDeletedEvent : V2.PushedEvent
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
        public Task<TaxId> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<TaxId>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public TaxId FetchRelatedObject()
        {
            return this.FetchRelatedObject<TaxId>(this.RelatedObject);
        }

        public V1CustomerTaxIdDeletedEvent Pull()
        {
            return this.PullEvent<V1CustomerTaxIdDeletedEvent>();
        }

        public Task<V1CustomerTaxIdDeletedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CustomerTaxIdDeletedEvent>();
        }
    }
}
