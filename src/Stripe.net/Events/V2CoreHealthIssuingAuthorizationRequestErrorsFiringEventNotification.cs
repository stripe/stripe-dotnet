// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an issuing authorization request errors alert is firing.
    /// </summary>
    public class V2CoreHealthIssuingAuthorizationRequestErrorsFiringEventNotification : V2.EventNotification
    {
        public V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent>();
        }

        public Task<V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthIssuingAuthorizationRequestErrorsFiringEvent>();
        }
    }
}
