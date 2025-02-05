// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class ClimateService : Service
    {
        private Climate.OrderService orders;
        private Climate.ProductService products;
        private Climate.SupplierService suppliers;

        internal ClimateService(ApiRequestor requestor)
            : base(requestor)
        {
        }

        internal ClimateService(IStripeClient client)
            : base(client)
        {
        }

        public virtual Climate.OrderService Orders => this.orders ??= new Climate.OrderService(
            this.Requestor);

        public virtual Climate.ProductService Products => this.products ??= new Climate.ProductService(
            this.Requestor);

        public virtual Climate.SupplierService Suppliers => this.suppliers ??= new Climate.SupplierService(
            this.Requestor);
    }
}
