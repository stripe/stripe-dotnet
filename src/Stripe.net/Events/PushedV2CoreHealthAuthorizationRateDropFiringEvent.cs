// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an authorization rate drop alert is firing.
    /// </summary>
    public class PushedV2CoreHealthAuthorizationRateDropFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthAuthorizationRateDropFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthAuthorizationRateDropFiringEvent>();
        }

        public Task<V2CoreHealthAuthorizationRateDropFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthAuthorizationRateDropFiringEvent>();
        }
    }
}
