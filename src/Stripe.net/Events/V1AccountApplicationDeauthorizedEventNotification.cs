// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever a user deauthorizes an application. Sent to the related application
    /// only.
    /// </summary>
    public class V1AccountApplicationDeauthorizedEventNotification : V2.Core.EventNotification
    {
        public V1AccountApplicationDeauthorizedEvent FetchEvent()
        {
            return this.FetchEvent<V1AccountApplicationDeauthorizedEvent>();
        }

        public Task<V1AccountApplicationDeauthorizedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1AccountApplicationDeauthorizedEvent>();
        }
    }
}
