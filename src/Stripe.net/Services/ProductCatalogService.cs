// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductCatalogService : Service
    {
        private ProductCatalog.TrialOfferService trialOffers;

        internal ProductCatalogService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProductCatalogService(IStripeClient client)
            : base(client)
        {
        }

        public virtual ProductCatalog.TrialOfferService TrialOffers => this.trialOffers ??= new ProductCatalog.TrialOfferService(
            this.Requestor);
    }
}
