// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Stripe Access Grant is approved.
    /// </summary>
    public class V2IamStripeAccessGrantApprovedEventNotification : V2.Core.EventNotification
    {
        public V2IamStripeAccessGrantApprovedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamStripeAccessGrantApprovedEvent>();
        }

        public Task<V2IamStripeAccessGrantApprovedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamStripeAccessGrantApprovedEvent>();
        }
    }
}
