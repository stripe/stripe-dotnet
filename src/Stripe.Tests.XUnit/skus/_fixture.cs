using System;
using System.Collections.Generic;
using System.Linq;

namespace Stripe.Tests.Xunit
{
    public class skus_fixture
    {
        public StripeSkuCreateOptions SkuCreateOptions { get; }
        public StripeSkuCreateOptions SkuTwoCreateOptions { get; }
        public StripeSkuUpdateOptions SkuUpdateOptions { get; }

        public StripeProduct Product { get; }
        public StripeSku Sku { get; }
        public StripeSku SkuTwo { get; }
        public StripeSku SkuUpdated { get; }
        public StripeSku SkuRetrieved { get; }
        public StripeList<StripeSku> SkuList { get; }

        public skus_fixture()
        {
            var productService = new StripeProductService(Cache.ApiKey);
            Product = productService.Create(new StripeProductCreateOptions {
                Name = "T-shirt",
                Type = "good",
                Description = "stripe-dotnet product description",
                Attributes = new string[] {"size", "color"},
            });

            SkuCreateOptions = new StripeSkuCreateOptions
            {
                Id = $"test-sku-{ Guid.NewGuid() }",
                Attributes = new Dictionary<string, string>
                {
                    { "size", "medium" },
                    { "color", "red" },
                },
                Currency = "usd",
                Inventory = new StripeInventoryOptions {
                    Quantity = 100,
                    Type = "finite",
                },
                PackageDimensions = new StripePackageDimensionOptions {
                    Height = 100,
                    Length = 100,
                    Weight = 100,
                    Width = 100,
                },
                Price = 1234,
                Product = Product.Id
            };

            SkuTwoCreateOptions = new StripeSkuCreateOptions
            {
                Id = $"test-sku-{ Guid.NewGuid() }",
                Attributes = new Dictionary<string, string>
                {
                    { "size", "large" },
                    { "color", "blue" },
                },
                Currency = "usd",
                Inventory = new StripeInventoryOptions {
                    Type = "infinite",
                },
                Price = 1345,
                Product = Product.Id
            };

            SkuUpdateOptions = new StripeSkuUpdateOptions
            {
                Price = 9999,
            };

            var service = new StripeSkuService(Cache.ApiKey);
            Sku = service.Create(SkuCreateOptions);
            SkuTwo = service.Create(SkuTwoCreateOptions);
            SkuUpdated = service.Update(Sku.Id, SkuUpdateOptions);
            SkuRetrieved = service.Get(Sku.Id);

            var SkuListOptions = new StripeSkuListOptions
            {
                Attributes = new Dictionary<string, string>
                {
                    { "size", "large" },
                },
                Product = Product.Id
            };

            SkuList = service.List(SkuListOptions);

            service.Delete(Sku.Id);
            service.Delete(SkuTwo.Id);
            productService.Delete(Product.Id);
        }
    }
}
