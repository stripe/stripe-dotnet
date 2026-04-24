// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class NetworkService : Service
    {
        private V2.Network.BusinessProfileService businessProfiles;

        internal NetworkService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal NetworkService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Network.BusinessProfileService BusinessProfiles => this.businessProfiles ??= new V2.Network.BusinessProfileService(
            this.Requestor);
    }
}
