// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs whenever a payment method is updated via the <a
    /// href="https://docs.stripe.com/api/payment_methods/update">PaymentMethod update API</a>.
    /// </summary>
    public class PushedV1PaymentMethodUpdatedEvent : V2.PushedEvent
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
        public Task<PaymentMethod> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<PaymentMethod>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public PaymentMethod FetchRelatedObject()
        {
            return this.FetchRelatedObject<PaymentMethod>(this.RelatedObject);
        }

        public V1PaymentMethodUpdatedEvent Pull()
        {
            return this.PullEvent<V1PaymentMethodUpdatedEvent>();
        }

        public Task<V1PaymentMethodUpdatedEvent> PullAsync()
        {
            return this.PullEventAsync<V1PaymentMethodUpdatedEvent>();
        }
    }
}
