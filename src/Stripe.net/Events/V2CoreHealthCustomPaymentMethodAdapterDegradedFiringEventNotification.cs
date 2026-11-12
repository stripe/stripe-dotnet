// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a custom payment method adapter degraded alert is firing.
    /// </summary>
    public class V2CoreHealthCustomPaymentMethodAdapterDegradedFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthCustomPaymentMethodAdapterDegradedFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthCustomPaymentMethodAdapterDegradedFiringEvent>();
        }

        public Task<V2CoreHealthCustomPaymentMethodAdapterDegradedFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthCustomPaymentMethodAdapterDegradedFiringEvent>();
        }
    }
}
