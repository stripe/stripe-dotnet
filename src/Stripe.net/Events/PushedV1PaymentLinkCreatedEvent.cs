// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when a payment link is created.
    /// </summary>
    public class PushedV1PaymentLinkCreatedEvent : V2.PushedEvent
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
        public Task<PaymentLink> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<PaymentLink>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public PaymentLink FetchRelatedObject()
        {
            return this.FetchRelatedObject<PaymentLink>(this.RelatedObject);
        }

        public V1PaymentLinkCreatedEvent Pull()
        {
            return this.PullEvent<V1PaymentLinkCreatedEvent>();
        }

        public Task<V1PaymentLinkCreatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1PaymentLinkCreatedEvent>();
        }
    }
}
