// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs X number of days before a subscription is scheduled to create an invoice that is
    /// automatically charged—where X is determined by your <a
    /// href="https://dashboard.stripe.com/account/billing/automatic">subscriptions
    /// settings</a>. Note: The received <c>Invoice</c> object will not have an invoice ID.
    /// </summary>
    public class V1InvoiceUpcomingEvent : V2.Core.Event
    {
    }
}
