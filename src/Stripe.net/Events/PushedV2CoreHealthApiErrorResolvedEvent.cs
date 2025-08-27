// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an API error alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthApiErrorResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthApiErrorResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthApiErrorResolvedEvent>();
        }

        public Task<V2CoreHealthApiErrorResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthApiErrorResolvedEvent>();
        }
    }
}
