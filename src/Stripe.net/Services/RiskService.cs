// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class RiskService : Service
    {
        private Risk.FormService forms;

        internal RiskService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal RiskService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Risk.FormService Forms => this.forms ??= new Risk.FormService(
            this.Requestor);
    }
}
