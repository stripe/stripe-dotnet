// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Stripe Access Grant is requested.
    /// </summary>
    public class V2IamStripeAccessGrantRequestedEventNotification : V2.Core.EventNotification
    {
        public V2IamStripeAccessGrantRequestedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamStripeAccessGrantRequestedEvent>();
        }

        public Task<V2IamStripeAccessGrantRequestedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamStripeAccessGrantRequestedEvent>();
        }
    }
}
