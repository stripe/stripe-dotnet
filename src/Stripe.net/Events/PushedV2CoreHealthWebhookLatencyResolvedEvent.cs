// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a webhook latency alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthWebhookLatencyResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthWebhookLatencyResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthWebhookLatencyResolvedEvent>();
        }

        public Task<V2CoreHealthWebhookLatencyResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthWebhookLatencyResolvedEvent>();
        }
    }
}
