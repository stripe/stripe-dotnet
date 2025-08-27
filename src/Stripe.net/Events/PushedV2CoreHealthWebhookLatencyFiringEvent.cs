// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a webhook latency alert is firing.
    /// </summary>
    public class PushedV2CoreHealthWebhookLatencyFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthWebhookLatencyFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthWebhookLatencyFiringEvent>();
        }

        public Task<V2CoreHealthWebhookLatencyFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthWebhookLatencyFiringEvent>();
        }
    }
}
