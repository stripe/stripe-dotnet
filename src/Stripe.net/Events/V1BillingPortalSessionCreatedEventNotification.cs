// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever a portal session is created.
    /// </summary>
    public class V1BillingPortalSessionCreatedEventNotification : V2.Core.EventNotification
    {
        public V1BillingPortalSessionCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1BillingPortalSessionCreatedEvent>();
        }

        public Task<V1BillingPortalSessionCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1BillingPortalSessionCreatedEvent>();
        }
    }
}
