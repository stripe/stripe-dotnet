// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an issuing authorization request timeout alert is firing.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthIssuingAuthorizationRequestTimeoutFiringEvent>();
        }
    }
}
