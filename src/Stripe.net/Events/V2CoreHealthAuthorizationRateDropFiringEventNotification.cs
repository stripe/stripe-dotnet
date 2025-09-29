// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an authorization rate drop alert is firing.
    /// </summary>
    public class V2CoreHealthAuthorizationRateDropFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthAuthorizationRateDropFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthAuthorizationRateDropFiringEvent>();
        }

        public Task<V2CoreHealthAuthorizationRateDropFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthAuthorizationRateDropFiringEvent>();
        }
    }
}
