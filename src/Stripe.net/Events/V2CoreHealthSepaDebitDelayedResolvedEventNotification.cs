// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a SEPA debit delayed alert is resolved.
    /// </summary>
    public class V2CoreHealthSepaDebitDelayedResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthSepaDebitDelayedResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthSepaDebitDelayedResolvedEvent>();
        }

        public Task<V2CoreHealthSepaDebitDelayedResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthSepaDebitDelayedResolvedEvent>();
        }
    }
}
