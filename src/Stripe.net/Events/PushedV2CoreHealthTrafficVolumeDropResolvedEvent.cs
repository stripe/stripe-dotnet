// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;

    /// <summary>
    /// Occurs when a traffic volume drop alert is resolved.
    /// </summary>
    public class PushedV2CoreHealthTrafficVolumeDropResolvedEvent : V2.PushedEvent
    {
        public V2CoreHealthTrafficVolumeDropResolvedEvent Pull()
        {
            return this.PullEvent<V2CoreHealthTrafficVolumeDropResolvedEvent>();
        }

        public Task<V2CoreHealthTrafficVolumeDropResolvedEvent> PullAsync()
        {
            return this.PullEventAsync<V2CoreHealthTrafficVolumeDropResolvedEvent>();
        }
    }
}
