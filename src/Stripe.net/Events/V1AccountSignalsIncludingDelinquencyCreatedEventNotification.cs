// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a delinquency signal is created for an account.
    /// </summary>
    public class V1AccountSignalsIncludingDelinquencyCreatedEventNotification : V2.Core.EventNotification
    {
        public V1AccountSignalsIncludingDelinquencyCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountSignalsIncludingDelinquencyCreatedEvent>();
        }

        public Task<V1AccountSignalsIncludingDelinquencyCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountSignalsIncludingDelinquencyCreatedEvent>();
        }
    }
}
