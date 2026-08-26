// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when all requested signals for an account evaluation are complete.
    /// </summary>
    public class V2SignalsAccountEvaluationCompleteEvent : V2.Core.Event
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
        public Task<V2.Signals.AccountEvaluation> FetchRelatedObjectAsync()
        {
            return this.FetchRelatedObjectAsync<V2.Signals.AccountEvaluation>(this.RelatedObject);
        }

        /// <summary>
        /// Retrieves the related object from the API. Make an API request on every call.
        /// </summary>
        public V2.Signals.AccountEvaluation FetchRelatedObject()
        {
            return this.FetchRelatedObject<V2.Signals.AccountEvaluation>(this.RelatedObject);
        }
    }
}
