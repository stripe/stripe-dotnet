// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Stripe.V2;

    /// <summary>
    /// Occurs when a traffic volume drop alert is firing.
    /// </summary>
    public class V2CoreHealthTrafficVolumeDropFiringEventNotification : V2.Core.EventNotification
    {
        public V2CoreHealthTrafficVolumeDropFiringEvent FetchEvent()
        {
            return this.FetchEvent<V2CoreHealthTrafficVolumeDropFiringEvent>();
        }

        public Task<V2CoreHealthTrafficVolumeDropFiringEvent> FetchEventAsync()
        {
            return this.FetchEventAsync<V2CoreHealthTrafficVolumeDropFiringEvent>();
        }
    }
}
