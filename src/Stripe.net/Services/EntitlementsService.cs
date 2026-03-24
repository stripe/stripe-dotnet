// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class EntitlementsService : Service
    {
        private Entitlements.ActiveEntitlementService activeEntitlements;
        private Entitlements.FeatureService features;

        internal EntitlementsService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal EntitlementsService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Entitlements.ActiveEntitlementService ActiveEntitlements => this.activeEntitlements ??= new Entitlements.ActiveEntitlementService(
            this.Requestor);

        public virtual Entitlements.FeatureService Features => this.features ??= new Entitlements.FeatureService(
            this.Requestor);
    }
}
