// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CommerceService : Service
    {
        private V2.Commerce.ProductCatalogService productCatalog;

        internal CommerceService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CommerceService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Commerce.ProductCatalogService ProductCatalog => this.productCatalog ??= new V2.Commerce.ProductCatalogService(
            this.Requestor);
    }
}
