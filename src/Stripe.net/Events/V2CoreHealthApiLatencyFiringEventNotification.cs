// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API latency alert is firing.
    /// </summary>
    public class V2CoreHealthApiLatencyFiringEventNotification : V2.EventNotification
    {
        public V2CoreHealthApiLatencyFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthApiLatencyFiringEvent>();
        }

        public Task<V2CoreHealthApiLatencyFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthApiLatencyFiringEvent>();
        }
    }
}
