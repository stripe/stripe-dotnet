// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when the fraud rate has increased.
    /// </summary>
    public class PushedV2CoreHealthFraudRateIncreasedEvent : V2.PushedEvent
    {
        public V2CoreHealthFraudRateIncreasedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthFraudRateIncreasedEvent>();
        }

        public Task<V2CoreHealthFraudRateIncreasedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthFraudRateIncreasedEvent>();
        }
    }
}
