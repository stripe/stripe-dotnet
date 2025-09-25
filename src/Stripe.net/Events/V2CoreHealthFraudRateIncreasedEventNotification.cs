// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when the fraud rate has increased.
    /// </summary>
    public class V2CoreHealthFraudRateIncreasedEventNotification : V2.EventNotification
    {
        public V2CoreHealthFraudRateIncreasedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthFraudRateIncreasedEvent>();
        }

        public Task<V2CoreHealthFraudRateIncreasedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthFraudRateIncreasedEvent>();
        }
    }
}
