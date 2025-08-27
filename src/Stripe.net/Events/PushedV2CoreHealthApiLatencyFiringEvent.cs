// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an API latency alert is firing.
    /// </summary>
    public class PushedV2CoreHealthApiLatencyFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthApiLatencyFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthApiLatencyFiringEvent>();
        }

        public Task<V2CoreHealthApiLatencyFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthApiLatencyFiringEvent>();
        }
    }
}
