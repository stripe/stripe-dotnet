// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a payment method error alert is firing.
    /// </summary>
    public class V2CoreHealthPaymentMethodErrorFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthPaymentMethodErrorFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthPaymentMethodErrorFiringEvent>();
        }

        public Task<V2CoreHealthPaymentMethodErrorFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthPaymentMethodErrorFiringEvent>();
        }
    }
}
