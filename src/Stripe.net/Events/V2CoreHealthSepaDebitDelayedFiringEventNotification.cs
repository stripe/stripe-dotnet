// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a SEPA debit delayed alert is firing.
    /// </summary>
    public class V2CoreHealthSepaDebitDelayedFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthSepaDebitDelayedFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthSepaDebitDelayedFiringEvent>();
        }

        public Task<V2CoreHealthSepaDebitDelayedFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthSepaDebitDelayedFiringEvent>();
        }
    }
}
