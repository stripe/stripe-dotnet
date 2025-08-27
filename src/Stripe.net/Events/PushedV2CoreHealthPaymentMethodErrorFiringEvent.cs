// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a payment method error alert is firing.
    /// </summary>
    public class PushedV2CoreHealthPaymentMethodErrorFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthPaymentMethodErrorFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthPaymentMethodErrorFiringEvent>();
        }

        public Task<V2CoreHealthPaymentMethodErrorFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthPaymentMethodErrorFiringEvent>();
        }
    }
}
