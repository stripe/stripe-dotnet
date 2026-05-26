// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an invoice count dropped alert is firing.
    /// </summary>
    public class V2CoreHealthInvoiceCountDroppedFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthInvoiceCountDroppedFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthInvoiceCountDroppedFiringEvent>();
        }

        public Task<V2CoreHealthInvoiceCountDroppedFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthInvoiceCountDroppedFiringEvent>();
        }
    }
}
