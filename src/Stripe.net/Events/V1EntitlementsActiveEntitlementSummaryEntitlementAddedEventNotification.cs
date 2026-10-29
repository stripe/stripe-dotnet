// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an entitlement is added to a customer's active entitlement summary.
    /// </summary>
    public class V1EntitlementsActiveEntitlementSummaryEntitlementAddedEventNotification : V2.Core.EventNotification
    {
        public V1EntitlementsActiveEntitlementSummaryEntitlementAddedEvent FetchEvent()
        {
            return this.FetchEvent<V1EntitlementsActiveEntitlementSummaryEntitlementAddedEvent>();
        }

        public Task<V1EntitlementsActiveEntitlementSummaryEntitlementAddedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1EntitlementsActiveEntitlementSummaryEntitlementAddedEvent>();
        }
    }
}
