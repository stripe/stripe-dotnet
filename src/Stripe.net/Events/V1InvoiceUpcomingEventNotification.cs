// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs X number of days before a subscription is scheduled to create an invoice that is
    /// automatically charged—where X is determined by your <a
    /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
    /// settings</a>. Note: The received <c>Invoice</c> object will not have an invoice ID.
    /// </summary>
    public class V1InvoiceUpcomingEventNotification : V2.Core.EventNotification
    {
        public V1InvoiceUpcomingEvent FetchEvent()
        {
            return this.FetchEvent<V1InvoiceUpcomingEvent>();
        }

        public Task<V1InvoiceUpcomingEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1InvoiceUpcomingEvent>();
        }
    }
}
