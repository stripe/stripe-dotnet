// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever a customer's entitlements change.
    /// </summary>
    public class V1EntitlementsActiveEntitlementSummaryUpdatedEventNotification : V2.Core.EventNotification
    {
        public V1EntitlementsActiveEntitlementSummaryUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1EntitlementsActiveEntitlementSummaryUpdatedEvent>();
        }

        public Task<V1EntitlementsActiveEntitlementSummaryUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1EntitlementsActiveEntitlementSummaryUpdatedEvent>();
        }
    }
}
