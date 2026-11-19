// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a custom payment method adapter degraded alert is resolved.
    /// </summary>
    public class V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEvent>();
        }

        public Task<V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEvent>();
        }
    }
}
