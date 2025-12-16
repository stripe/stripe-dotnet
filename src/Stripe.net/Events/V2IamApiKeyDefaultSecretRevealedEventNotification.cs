// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when the default API Key's secret is revealed.
    /// </summary>
    public class V2IamApiKeyDefaultSecretRevealedEventNotification : V2.Core.EventNotification
    {
        public V2IamApiKeyDefaultSecretRevealedEvent FetchEvent()
        {
            return this.FetchEvent<V2IamApiKeyDefaultSecretRevealedEvent>();
        }

        public Task<V2IamApiKeyDefaultSecretRevealedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2IamApiKeyDefaultSecretRevealedEvent>();
        }
    }
}
