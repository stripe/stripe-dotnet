// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ReserveService : Service
    {
        private Reserve.HoldService holds;
        private Reserve.PlanService plans;
        private Reserve.ReleaseService releases;

        internal ReserveService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ReserveService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Reserve.HoldService Holds => this.holds ??= new Reserve.HoldService(
            this.Requestor);

        public virtual Reserve.PlanService Plans => this.plans ??= new Reserve.PlanService(
            this.Requestor);

        public virtual Reserve.ReleaseService Releases => this.releases ??= new Reserve.ReleaseService(
            this.Requestor);
    }
}
