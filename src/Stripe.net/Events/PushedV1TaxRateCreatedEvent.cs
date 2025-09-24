// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a new tax rate is created.
    /// </summary>
    public class PushedV1TaxRateCreatedEvent : V2.PushedEvent
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
        public Task<TaxRate> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<TaxRate>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public TaxRate FetchRelatedObject()
        {
            return this.FetchRelatedObject<TaxRate>(this.RelatedObject);
        }

        public V1TaxRateCreatedEvent Pull()
        {
            return this.PullEvent<V1TaxRateCreatedEvent>();
        }

        public Task<V1TaxRateCreatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1TaxRateCreatedEvent>();
        }
    }
}
