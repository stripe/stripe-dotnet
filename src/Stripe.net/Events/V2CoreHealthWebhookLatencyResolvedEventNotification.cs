// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a webhook latency alert is resolved.
    /// </summary>
    public class V2CoreHealthWebhookLatencyResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthWebhookLatencyResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthWebhookLatencyResolvedEvent>();
        }

        public Task<V2CoreHealthWebhookLatencyResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthWebhookLatencyResolvedEvent>();
        }
    }
}
