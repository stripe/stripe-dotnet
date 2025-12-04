// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API Key is created.
    /// </summary>
    public class V2IamApiKeyCreatedEventNotification : V2.Core.EventNotification
    {
        public V2IamApiKeyCreatedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamApiKeyCreatedEvent>();
        }

        public Task<V2IamApiKeyCreatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamApiKeyCreatedEvent>();
        }
    }
}
