// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an issuing authorization request timeout alert is resolved.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEventNotification : V2.EventNotification
    {
        public V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthIssuingAuthorizationRequestTimeoutResolvedEvent>();
        }
    }
}
