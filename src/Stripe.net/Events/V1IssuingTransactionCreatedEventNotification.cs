// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.V2;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever an issuing transaction is created.
    /// </summary>
    public class V1IssuingTransactionCreatedEventNotification : V2.Core.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.Core.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<Issuing.Transaction> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<Issuing.Transaction>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public Issuing.Transaction FetchRelatedObject()
        {
            return this.FetchRelatedObject<Issuing.Transaction>(this.RelatedObject);
        }

        public V1IssuingTransactionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1IssuingTransactionCreatedEvent>();
        }

        public Task<V1IssuingTransactionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1IssuingTransactionCreatedEvent>();
        }
    }
}
