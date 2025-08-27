// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an API latency alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthApiLatencyResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthApiLatencyResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthApiLatencyResolvedEvent>();
        }

        public Task<V2CoreHealthApiLatencyResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthApiLatencyResolvedEvent>();
        }
    }
}
