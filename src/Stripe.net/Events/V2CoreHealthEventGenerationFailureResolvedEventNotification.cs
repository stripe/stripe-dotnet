// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an event generation failure alert is resolved.
    /// </summary>
    public class V2CoreHealthEventGenerationFailureResolvedEventNotification : V2.EventNotification
    {
        public V2CoreHealthEventGenerationFailureResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthEventGenerationFailureResolvedEvent>();
        }

        public Task<V2CoreHealthEventGenerationFailureResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthEventGenerationFailureResolvedEvent>();
        }
    }
}
