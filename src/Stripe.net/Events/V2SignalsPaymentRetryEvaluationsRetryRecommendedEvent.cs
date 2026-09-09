// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Occurs when the ML scoring model determines it's a good time to retry a failed payment.
    /// This is a thin event — the merchant must call GET to retrieve the full evaluation.
    /// </summary>
    public class V2SignalsPaymentRetryEvaluationsRetryRecommendedEvent : V2.Core.Event
    {
        /// <summary>
        /// Data for the v2.signals.payment_retry_evaluations.retry_recommended event.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]

        public V2SignalsPaymentRetryEvaluationsRetryRecommendedEventData Data { get; set; }
    }
}
