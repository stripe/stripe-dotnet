// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API error alert is firing.
    /// </summary>
    public class V2CoreHealthApiErrorFiringEventNotification : V2.EventNotification
    {
        public V2CoreHealthApiErrorFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthApiErrorFiringEvent>();
        }

        public Task<V2CoreHealthApiErrorFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthApiErrorFiringEvent>();
        }
    }
}
