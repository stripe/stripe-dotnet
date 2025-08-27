// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an authorization rate drop alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthAuthorizationRateDropResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthAuthorizationRateDropResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthAuthorizationRateDropResolvedEvent>();
        }

        public Task<V2CoreHealthAuthorizationRateDropResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthAuthorizationRateDropResolvedEvent>();
        }
    }
}
