// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API Key is rotated.
    /// </summary>
    public class V2IamApiKeyRotatedEventNotification : V2.Core.EventNotification
    {
        public V2IamApiKeyRotatedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamApiKeyRotatedEvent>();
        }

        public Task<V2IamApiKeyRotatedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamApiKeyRotatedEvent>();
        }
    }
}
