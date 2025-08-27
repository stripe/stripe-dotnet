// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an API error alert is firing.
    /// </summary>
    public class PushedV2CoreHealthApiErrorFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthApiErrorFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthApiErrorFiringEvent>();
        }

        public Task<V2CoreHealthApiErrorFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthApiErrorFiringEvent>();
        }
    }
}
