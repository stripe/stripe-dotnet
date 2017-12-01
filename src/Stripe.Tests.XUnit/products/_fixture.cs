using System;
using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class products_fixture
    {
        public StripeProductCreateOptions ProductCreateOptions { get; }
        public StripeProductCreateOptions ProductTwoCreateOptions { get; }
        public StripeProductUpdateOptions ProductUpdateOptions { get; }
        public StripeProductListOptions ProductListOptions { get; }

        public StripeProduct Product { get; }
        public StripeProduct ProductTwo { get; }
        public StripeProduct ProductUpdated { get; }
        public StripeProduct ProductRetrieved { get; }
        public StripeList<StripeProduct> ProductList { get; }

        public products_fixture()
        {
            ProductCreateOptions = new StripeProductCreateOptions
            {
                Name = $"test-product-{ Guid.NewGuid() }",
                Type = "good",
                PackageDimensions = new StripePackageDimensionOptions {
                    Height = 100,
                    Length = 100,
                    Weight = 100,
                    Width = 100,
                },
                Attributes = new string[] { "color", "size" },
            };

            ProductTwoCreateOptions = new StripeProductCreateOptions
            {
                Name = $"test-product-{ Guid.NewGuid() }",
                Type = "good",
            };

            ProductUpdateOptions = new StripeProductUpdateOptions
            {
                Name = $"test-product-{ Guid.NewGuid() }",
            };

            var service = new StripeProductService(Cache.ApiKey);
            Product = service.Create(ProductCreateOptions);
            ProductTwo = service.Create(ProductTwoCreateOptions);
            ProductUpdated = service.Update(Product.Id, ProductUpdateOptions);
            ProductRetrieved = service.Get(Product.Id);

            ProductListOptions = new StripeProductListOptions
            {
                Url = Product.Url,
                Ids = new [] { Product.Id, ProductTwo.Id }
            };

            ProductList = service.List(ProductListOptions);

            service.Delete(Product.Id);
            service.Delete(ProductTwo.Id);
        }
    }
}
