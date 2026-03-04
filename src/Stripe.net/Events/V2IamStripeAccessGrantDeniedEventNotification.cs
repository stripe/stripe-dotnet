// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Stripe Access Grant is denied (was pending, then denied by the customer).
    /// </summary>
    public class V2IamStripeAccessGrantDeniedEventNotification : V2.Core.EventNotification
    {
        public V2IamStripeAccessGrantDeniedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamStripeAccessGrantDeniedEvent>();
        }

        public Task<V2IamStripeAccessGrantDeniedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamStripeAccessGrantDeniedEvent>();
        }
    }
}
