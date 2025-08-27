// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a payment method error alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthPaymentMethodErrorResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthPaymentMethodErrorResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthPaymentMethodErrorResolvedEvent>();
        }

        public Task<V2CoreHealthPaymentMethodErrorResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthPaymentMethodErrorResolvedEvent>();
        }
    }
}
