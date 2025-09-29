// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a traffic volume drop alert is resolved.
    /// </summary>
    public class V2CoreHealthTrafficVolumeDropResolvedEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthTrafficVolumeDropResolvedEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthTrafficVolumeDropResolvedEvent>();
        }

        public Task<V2CoreHealthTrafficVolumeDropResolvedEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthTrafficVolumeDropResolvedEvent>();
        }
    }
}
