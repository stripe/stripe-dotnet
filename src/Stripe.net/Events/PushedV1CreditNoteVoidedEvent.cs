// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a credit note is voided.
    /// </summary>
    public class PushedV1CreditNoteVoidedEvent : V2.PushedEvent
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
        public Task<CreditNote> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<CreditNote>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public CreditNote FetchRelatedObject()
        {
            return this.FetchRelatedObject<CreditNote>(this.RelatedObject);
        }

        public V1CreditNoteVoidedEvent Pull()
        {
            return this.PullEvent<V1CreditNoteVoidedEvent>();
        }

        public Task<V1CreditNoteVoidedEvent> PullAsync()
        {
            return this.PullEventAsync<V1CreditNoteVoidedEvent>();
        }
    }
}
