// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an invoice count dropped alert is resolved.
    /// </summary>
    public class V2CoreHealthInvoiceCountDroppedResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthInvoiceCountDroppedResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthInvoiceCountDroppedResolvedEvent>();
        }

        public Task<V2CoreHealthInvoiceCountDroppedResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthInvoiceCountDroppedResolvedEvent>();
        }
    }
}
