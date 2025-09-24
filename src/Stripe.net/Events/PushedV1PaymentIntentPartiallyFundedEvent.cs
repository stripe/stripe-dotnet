// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Occurs when funds are applied to a customer_balance PaymentIntent and the
    /// 'amount_remaining' changes.
    /// </summary>
    public class PushedV1PaymentIntentPartiallyFundedEvent : V2.PushedEvent
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

        public V1PaymentIntentPartiallyFundedEvent Pull()
        {
            return this.PullEvent<V1PaymentIntentPartiallyFundedEvent>();
        }

        public Task<V1PaymentIntentPartiallyFundedEvent> PullAsync()
        {
            return this.PullEventAsync<V1PaymentIntentPartiallyFundedEvent>();
        }
    }
}
