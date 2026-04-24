// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a meter event summaries delayed alert is firing.
    /// </summary>
    public class V2CoreHealthMeterEventSummariesDelayedFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthMeterEventSummariesDelayedFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthMeterEventSummariesDelayedFiringEvent>();
        }

        public Task<V2CoreHealthMeterEventSummariesDelayedFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthMeterEventSummariesDelayedFiringEvent>();
        }
    }
}
