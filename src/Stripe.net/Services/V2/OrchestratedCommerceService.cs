// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class OrchestratedCommerceService : Service
    {
        private V2.OrchestratedCommerce.AgreementService agreements;

        internal OrchestratedCommerceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal OrchestratedCommerceService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.OrchestratedCommerce.AgreementService Agreements => this.agreements ??= new V2.OrchestratedCommerce.AgreementService(
            this.Requestor);
    }
}
