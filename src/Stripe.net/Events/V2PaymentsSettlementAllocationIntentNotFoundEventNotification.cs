// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a ReceivedCredit has no SettlementAllocationIntent matching it.
    /// </summary>
    public class V2PaymentsSettlementAllocationIntentNotFoundEventNotification : V2.Core.EventNotification
    {
        public V2PaymentsSettlementAllocationIntentNotFoundEvent FetchEvent()
        {
            return this.FetchEvent<V2PaymentsSettlementAllocationIntentNotFoundEvent>();
        }

        public Task<V2PaymentsSettlementAllocationIntentNotFoundEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2PaymentsSettlementAllocationIntentNotFoundEvent>();
        }
    }
}
