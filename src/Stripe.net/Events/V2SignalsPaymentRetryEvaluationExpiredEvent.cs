// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when a payment retry evaluation expires after retry scoring gives up.
    /// </summary>
    public class V2SignalsPaymentRetryEvaluationExpiredEvent : V2.Core.Event
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
        public Task<V2.Signals.PaymentRetryEvaluation> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Signals.PaymentRetryEvaluation>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Signals.PaymentRetryEvaluation FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Signals.PaymentRetryEvaluation>(this.RelatedObject);
        }
    }
}
