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
    /// Occurs when a PaymentIntent transitions to requires_action state.
    /// </summary>
    public class V1PaymentIntentRequiresActionEventNotification : V2.EventNotification
    {
        /// <summary>
        /// Object containing the reference to API resource relevant to the event.
        /// </summary>
        [JsonProperty("related_object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("related_object")]
#endif

        public V2.EventNotificationRelatedObject RelatedObject { get; set; }

        /// <summary>
        /// Asynchronously retrieves the related object from the API. Make an API request on every
        /// call.
        /// </summary>
        public Task<PaymentIntent> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<PaymentIntent>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public PaymentIntent FetchRelatedObject()
        {
            return this.FetchRelatedObject<PaymentIntent>(this.RelatedObject);
        }

        public V1PaymentIntentRequiresActionEvent FetchEvent()
        {
            return this.FetchEvent<V1PaymentIntentRequiresActionEvent>();
        }

        public Task<V1PaymentIntentRequiresActionEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PaymentIntentRequiresActionEvent>();
        }
    }
}
