// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a Meter's id is missing or invalid in async usage events.
    /// </summary>
    public class PushedV1BillingMeterNoMeterFoundEvent : V2.PushedEvent
    {
        public V1BillingMeterNoMeterFoundEvent Pull()
        {
            return this.PullEvent<V1BillingMeterNoMeterFoundEvent>();
        }

        public Task<V1BillingMeterNoMeterFoundEvent> PullAsync()
        {
            return this.PullEventAsync<V1BillingMeterNoMeterFoundEvent>();
        }
    }
}
