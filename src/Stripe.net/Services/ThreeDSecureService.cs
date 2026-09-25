// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ThreeDSecureService : Service
    {
        private ThreeDSecure.AuthenticationService authentications;

        internal ThreeDSecureService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ThreeDSecureService(IStripeClient client)
            : base(client)
        {
        }

        public virtual ThreeDSecure.AuthenticationService Authentications => this.authentications ??= new ThreeDSecure.AuthenticationService(
            this.Requestor);
    }
}
