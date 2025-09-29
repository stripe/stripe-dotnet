// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a webhook latency alert is firing.
    /// </summary>
    public class V2CoreHealthWebhookLatencyFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthWebhookLatencyFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthWebhookLatencyFiringEvent>();
        }

        public Task<V2CoreHealthWebhookLatencyFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthWebhookLatencyFiringEvent>();
        }
    }
}
