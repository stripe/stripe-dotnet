// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a payment method error alert is resolved.
    /// </summary>
    public class V2CoreHealthPaymentMethodErrorResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthPaymentMethodErrorResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthPaymentMethodErrorResolvedEvent>();
        }

        public Task<V2CoreHealthPaymentMethodErrorResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthPaymentMethodErrorResolvedEvent>();
        }
    }
}
