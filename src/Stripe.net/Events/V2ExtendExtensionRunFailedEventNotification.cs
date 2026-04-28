// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an extension run fails.
    /// </summary>
    public class V2ExtendExtensionRunFailedEventNotification : V2.Core.EventNotification
    {
        public V2ExtendExtensionRunFailedEvent FetchEvent()
        {
            return this.FetchEvent<V2ExtendExtensionRunFailedEvent>();
        }

        public Task<V2ExtendExtensionRunFailedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2ExtendExtensionRunFailedEvent>();
        }
    }
}
