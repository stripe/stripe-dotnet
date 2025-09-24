// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an issuing authorization request errors alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent>();
        }
    }
}
