// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a meter event summaries delayed alert is resolved.
    /// </summary>
    public class V2CoreHealthMeterEventSummariesDelayedResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthMeterEventSummariesDelayedResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthMeterEventSummariesDelayedResolvedEvent>();
        }

        public Task<V2CoreHealthMeterEventSummariesDelayedResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthMeterEventSummariesDelayedResolvedEvent>();
        }
    }
}
