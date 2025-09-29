// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an authorization rate drop alert is resolved.
    /// </summary>
    public class V2CoreHealthAuthorizationRateDropResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthAuthorizationRateDropResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthAuthorizationRateDropResolvedEvent>();
        }

        public Task<V2CoreHealthAuthorizationRateDropResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthAuthorizationRateDropResolvedEvent>();
        }
    }
}
