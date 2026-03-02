// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Stripe Access Grant is updated.
    /// </summary>
    public class V2IamStripeAccessGrantUpdatedEventNotification : V2.Core.EventNotification
    {
        public V2IamStripeAccessGrantUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamStripeAccessGrantUpdatedEvent>();
        }

        public Task<V2IamStripeAccessGrantUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamStripeAccessGrantUpdatedEvent>();
        }
    }
}
