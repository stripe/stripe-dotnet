// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Metronome notification latency alert is firing.
    /// </summary>
    public class V2CoreHealthMetronomeNotificationLatencyFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthMetronomeNotificationLatencyFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthMetronomeNotificationLatencyFiringEvent>();
        }

        public Task<V2CoreHealthMetronomeNotificationLatencyFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthMetronomeNotificationLatencyFiringEvent>();
        }
    }
}
