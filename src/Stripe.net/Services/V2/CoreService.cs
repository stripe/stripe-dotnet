// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CoreService : Service
    {
        private V2.Core.EventDestinationService eventDestinations;
        private V2.Core.EventService events;

        internal CoreService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CoreService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Core.EventDestinationService EventDestinations => this.eventDestinations ??= new V2.Core.EventDestinationService(
            this.Requestor);

        public virtual V2.Core.EventService Events => this.events ??= new V2.Core.EventService(
            this.Requestor);
    }
}
