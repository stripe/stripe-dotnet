// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a Stripe Access Grant is canceled by the requesting Stripe.
    /// </summary>
    public class V2IamStripeAccessGrantCanceledEventNotification : V2.Core.EventNotification
    {
        public V2IamStripeAccessGrantCanceledEvent FetchEvent()
        {
            return this.FetchEvent<V2IamStripeAccessGrantCanceledEvent>();
        }

        public Task<V2IamStripeAccessGrantCanceledEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamStripeAccessGrantCanceledEvent>();
        }
    }
}
