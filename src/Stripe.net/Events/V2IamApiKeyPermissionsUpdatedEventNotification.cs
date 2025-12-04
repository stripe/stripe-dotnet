// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API Key's permissions are updated.
    /// </summary>
    public class V2IamApiKeyPermissionsUpdatedEventNotification : V2.Core.EventNotification
    {
        public V2IamApiKeyPermissionsUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamApiKeyPermissionsUpdatedEvent>();
        }

        public Task<V2IamApiKeyPermissionsUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamApiKeyPermissionsUpdatedEvent>();
        }
    }
}
