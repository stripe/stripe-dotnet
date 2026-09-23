// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CatalogService : Service
    {
        private V2.Provisioning.Catalog.ProviderService providers;
        private V2.Provisioning.Catalog.ServiceService services;

        internal CatalogService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal CatalogService(IStripeClient client)
            : base(client)
        {
        }

        public virtual V2.Provisioning.Catalog.ProviderService Providers => this.providers ??= new V2.Provisioning.Catalog.ProviderService(
            this.Requestor);

        public virtual V2.Provisioning.Catalog.ServiceService Services => this.services ??= new V2.Provisioning.Catalog.ServiceService(
            this.Requestor);
    }
}
