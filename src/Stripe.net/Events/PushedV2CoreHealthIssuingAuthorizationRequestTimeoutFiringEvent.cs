// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an issuing authorization request timeout alert is firing.
    /// </summary>
    public class PushedV2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent>();
        }
    }
}
