// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever an external account is updated.
    /// </summary>
    public class V1AccountExternalAccountUpdatedEventNotification : V2.Core.EventNotification
    {
        public V1AccountExternalAccountUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountExternalAccountUpdatedEvent>();
        }

        public Task<V1AccountExternalAccountUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountExternalAccountUpdatedEvent>();
        }
    }
}
