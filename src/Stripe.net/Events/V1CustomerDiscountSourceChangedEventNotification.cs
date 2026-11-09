// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs whenever the source of a customer's discount changes.
    /// </summary>
    public class V1CustomerDiscountSourceChangedEventNotification : V2.Core.EventNotification
    {
        public V1CustomerDiscountSourceChangedEvent FetchEvent()
        {
            return this.FetchEvent<V1CustomerDiscountSourceChangedEvent>();
        }

        public Task<V1CustomerDiscountSourceChangedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V1CustomerDiscountSourceChangedEvent>();
        }
    }
}
