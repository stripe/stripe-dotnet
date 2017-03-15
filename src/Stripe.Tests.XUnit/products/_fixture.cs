using System;

namespace Stripe.Tests.Xunit
{
    public class product_fixture : IDisposable
    {
        public StripeProduct Product { get; }
        public StripeProduct ProductUpdated { get; }
        public StripeProductCreateOptions ProductCreateOptions { get; }
        public StripeProductUpdateOptions ProductUpdateOptions { get; }

        public product_fixture()
        {
            Product = Cache.GetProduct();
            ProductCreateOptions = Cache.GetProductCreateOptions();
            ProductUpdateOptions = Cache.GetProductUpdateOptions();
            var productToUpdate = Cache.GetProductToUpdate();
            var service = new StripeProductService(Cache.ApiKey);
            ProductUpdated = service.Update(productToUpdate.Id, Cache.GetProductUpdateOptions());
        }

        public void Dispose()
        {
            new StripeProductService(Cache.ApiKey).Delete(ProductUpdated.Id);
        }
    }
}
