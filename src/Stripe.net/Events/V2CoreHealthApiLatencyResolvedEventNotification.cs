// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API latency alert is resolved.
    /// </summary>
    public class V2CoreHealthApiLatencyResolvedEventNotification : V2.EventNotification
    {
        public V2CoreHealthApiLatencyResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthApiLatencyResolvedEvent>();
        }

        public Task<V2CoreHealthApiLatencyResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthApiLatencyResolvedEvent>();
        }
    }
}
