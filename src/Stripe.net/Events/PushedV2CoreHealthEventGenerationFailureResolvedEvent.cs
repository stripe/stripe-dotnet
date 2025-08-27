// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when an event generation failure alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthEventGenerationFailureResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthEventGenerationFailureResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthEventGenerationFailureResolvedEvent>();
        }

        public Task<V2CoreHealthEventGenerationFailureResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthEventGenerationFailureResolvedEvent>();
        }
    }
}
