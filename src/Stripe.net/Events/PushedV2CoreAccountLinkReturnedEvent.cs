// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when the generated AccountLink is completed.
    /// </summary>
    public class PushedV2CoreAccountLinkReturnedEvent : V2.PushedEvent
    {
        public V2CoreAccountLinkReturnedEvent Pull()
        {
            return this.PullEvent<V2CoreAccountLinkReturnedEvent>();
        }

        public Task<V2CoreAccountLinkReturnedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreAccountLinkReturnedEvent>();
        }
    }
}
