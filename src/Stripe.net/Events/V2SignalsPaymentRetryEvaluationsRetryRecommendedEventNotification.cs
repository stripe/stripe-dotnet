// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when the ML scoring model determines it's a good time to retry a failed payment.
    /// This is a thin event — the merchant must call GET to retrieve the full evaluation.
    /// </summary>
    public class V2SignalsPaymentRetryEvaluationsRetryRecommendedEventNotification : V2.Core.EventNotification
    {
        public V2SignalsPaymentRetryEvaluationsRetryRecommendedEvent FetchEvent()
        {
            return this.FetchEvent<V2SignalsPaymentRetryEvaluationsRetryRecommendedEvent>();
        }

        public Task<V2SignalsPaymentRetryEvaluationsRetryRecommendedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2SignalsPaymentRetryEvaluationsRetryRecommendedEvent>();
        }
    }
}
