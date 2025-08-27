// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an issuing authorization request timeout alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent>();
        }
    }
}
