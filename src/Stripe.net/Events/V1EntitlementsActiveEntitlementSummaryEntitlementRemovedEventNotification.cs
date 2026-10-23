// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an entitlement is removed from a customer's active entitlement summary.
    /// </summary>
    public class V1EntitlementsActiveEntitlementSummaryEntitlementRemovedEventNotification : V2.Core.EventNotification
    {
        public V1EntitlementsActiveEntitlementSummaryEntitlementRemovedEvent FetchEvent()
        {
            return this.FetchEvent<V1EntitlementsActiveEntitlementSummaryEntitlementRemovedEvent>();
        }

        public Task<V1EntitlementsActiveEntitlementSummaryEntitlementRemovedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1EntitlementsActiveEntitlementSummaryEntitlementRemovedEvent>();
        }
    }
}
