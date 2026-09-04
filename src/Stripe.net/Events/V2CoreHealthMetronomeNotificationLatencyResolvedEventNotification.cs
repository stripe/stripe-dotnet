// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Metronome notification latency alert is resolved.
    /// </summary>
    public class V2CoreHealthMetronomeNotificationLatencyResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthMetronomeNotificationLatencyResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthMetronomeNotificationLatencyResolvedEvent>();
        }

        public Task<V2CoreHealthMetronomeNotificationLatencyResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthMetronomeNotificationLatencyResolvedEvent>();
        }
    }
}
