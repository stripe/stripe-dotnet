// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Meter's id is missing or invalid in async usage events.
    /// </summary>
    public class V1BillingMeterNoMeterFoundEventNotification : V2.Core.EventNotification
    {
        public V1BillingMeterNoMeterFoundEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingMeterNoMeterFoundEvent>();
        }

        public Task<V1BillingMeterNoMeterFoundEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingMeterNoMeterFoundEvent>();
        }
    }
}
