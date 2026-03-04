// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Stripe Access Grant is removed (was approved, and then removed by the
    /// customer).
    /// </summary>
    public class V2IamStripeAccessGrantRemovedEventNotification : V2.Core.EventNotification
    {
        public V2IamStripeAccessGrantRemovedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamStripeAccessGrantRemovedEvent>();
        }

        public Task<V2IamStripeAccessGrantRemovedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamStripeAccessGrantRemovedEvent>();
        }
    }
}
