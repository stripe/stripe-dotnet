// File generated from our OpenAPI spec
namespace Stripe.V2.Commerce
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ProductCatalogService : Service
    {
        private V2.Commerce.ProductCatalog.ImportService imports;

        internal ProductCatalogService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ProductCatalogService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Commerce.ProductCatalog.ImportService Imports => this.imports ??= new V2.Commerce.ProductCatalog.ImportService(
            this.Requestor);
    }
}
