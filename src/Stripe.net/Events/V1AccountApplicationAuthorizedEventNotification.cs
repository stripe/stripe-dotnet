// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever a user authorizes an application. Sent to the related application only.
    /// </summary>
    public class V1AccountApplicationAuthorizedEventNotification : V2.Core.EventNotification
    {
        public V1AccountApplicationAuthorizedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountApplicationAuthorizedEvent>();
        }

        public Task<V1AccountApplicationAuthorizedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountApplicationAuthorizedEvent>();
        }
    }
}
