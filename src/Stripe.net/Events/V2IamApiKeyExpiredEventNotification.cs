// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API Key is expired.
    /// </summary>
    public class V2IamApiKeyExpiredEventNotification : V2.Core.EventNotification
    {
        public V2IamApiKeyExpiredEvent FetchEvent()
        {
            return this.FetchEvent<V2IamApiKeyExpiredEvent>();
        }

        public Task<V2IamApiKeyExpiredEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamApiKeyExpiredEvent>();
        }
    }
}
