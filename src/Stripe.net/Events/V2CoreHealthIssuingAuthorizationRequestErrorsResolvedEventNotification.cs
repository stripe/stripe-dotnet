// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an issuing authorization request errors alert is resolved.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthIssuingAuthorizationRequestErrorsResolvedEvent>();
        }
    }
}
