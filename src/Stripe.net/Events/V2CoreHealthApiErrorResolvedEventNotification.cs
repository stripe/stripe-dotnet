// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when an API error alert is resolved.
    /// </summary>
    public class V2CoreHealthApiErrorResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthApiErrorResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthApiErrorResolvedEvent>();
        }

        public Task<V2CoreHealthApiErrorResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthApiErrorResolvedEvent>();
        }
    }
}
