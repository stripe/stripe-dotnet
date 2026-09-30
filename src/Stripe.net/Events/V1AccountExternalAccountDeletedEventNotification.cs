// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever an external account is deleted.
    /// </summary>
    public class V1AccountExternalAccountDeletedEventNotification : V2.Core.EventNotification
    {
        public V1AccountExternalAccountDeletedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountExternalAccountDeletedEvent>();
        }

        public Task<V1AccountExternalAccountDeletedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountExternalAccountDeletedEvent>();
        }
    }
}
