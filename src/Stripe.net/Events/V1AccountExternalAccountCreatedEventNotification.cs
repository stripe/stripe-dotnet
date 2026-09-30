// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever an external account is created.
    /// </summary>
    public class V1AccountExternalAccountCreatedEventNotification : V2.Core.EventNotification
    {
        public V1AccountExternalAccountCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountExternalAccountCreatedEvent>();
        }

        public Task<V1AccountExternalAccountCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountExternalAccountCreatedEvent>();
        }
    }
}
