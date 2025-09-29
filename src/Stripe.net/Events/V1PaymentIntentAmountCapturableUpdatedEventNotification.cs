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
    /// Occurs when a PaymentIntent has funds to be captured. Check the <c>amount_capturable</c>
    /// property on the PaymentIntent to determine the amount that can be captured. You may
    /// capture the PaymentIntent with an <c>amount_to_capture</c> value up to the specified
    /// amount. <a href="https://docs.stripe.com/api/payment_intents/capture">Learn more about
    /// capturing PaymentIntents.</a>.
    /// </summary>
    public class V1PaymentIntentAmountCapturableUpdatedEventNotification : V2.Core.EventNotification
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

        public V1PaymentIntentAmountCapturableUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1PaymentIntentAmountCapturableUpdatedEvent>();
        }

        public Task<V1PaymentIntentAmountCapturableUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1PaymentIntentAmountCapturableUpdatedEvent>();
        }
    }
}
