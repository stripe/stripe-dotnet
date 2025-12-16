// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API Key is updated.
    /// </summary>
    public class V2IamApiKeyUpdatedEventNotification : V2.Core.EventNotification
    {
        public V2IamApiKeyUpdatedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamApiKeyUpdatedEvent>();
        }

        public Task<V2IamApiKeyUpdatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamApiKeyUpdatedEvent>();
        }
    }
}
