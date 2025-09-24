// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an issuing authorization request errors alert is firing.
    /// </summary>
    public class PushedV2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent>();
        }
    }
}
