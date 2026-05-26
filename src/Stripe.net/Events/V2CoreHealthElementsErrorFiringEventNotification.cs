// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an elements error alert is firing.
    /// </summary>
    public class V2CoreHealthElementsErrorFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthElementsErrorFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthElementsErrorFiringEvent>();
        }

        public Task<V2CoreHealthElementsErrorFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthElementsErrorFiringEvent>();
        }
    }
}
