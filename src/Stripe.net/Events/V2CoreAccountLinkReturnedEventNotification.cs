// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when the generated AccountLink is completed.
    /// </summary>
    public class V2CoreAccountLinkReturnedEventNotification : V2.EventNotification
    {
        public V2CoreAccountLinkReturnedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreAccountLinkReturnedEvent>();
        }

        public Task<V2CoreAccountLinkReturnedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreAccountLinkReturnedEvent>();
        }
    }
}
