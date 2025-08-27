// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a traffic volume drop alert is firing.
    /// </summary>
    public class PushedV2CoreHealthTrafficVolumeDropFiringEvent : V2.PushedEvent
    {
        public V2CoreHealthTrafficVolumeDropFiringEvent Pull()
        {
            return this.PullEvent<V2CoreHealthTrafficVolumeDropFiringEvent>();
        }

        public Task<V2CoreHealthTrafficVolumeDropFiringEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthTrafficVolumeDropFiringEvent>();
        }
    }
}
