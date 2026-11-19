// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CapitalService : Service
    {
        private TestHelpers.Capital.FinancingOfferService financingOffers;

        internal CapitalService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CapitalService(IStripeClient client)
            : base(client)
        {
        }

        public virtual TestHelpers.Capital.FinancingOfferService FinancingOffers => this.financingOffers ??= new TestHelpers.Capital.FinancingOfferService(
            this.Requestor);
    }
}
