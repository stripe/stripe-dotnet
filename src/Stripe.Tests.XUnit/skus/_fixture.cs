using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class sku_fixture : IDisposable
    {
        public StripeSku SkuCreated { get; }
        public StripeSku SkuUpdated { get; }
        public StripeSkuCreateOptions SkuCreateOptions { get; }
        public StripeSkuCreateOptions SkuToUpdateCreateOptions { get; }
        public StripeSkuUpdateOptions SkuUpdateOptions { get; }

        private StripeProduct Product { get; }


        public sku_fixture()
        {
            var productFixture = new product_fixture();
            Product = productFixture.ProductCreated;

            SkuCreateOptions = GenerateSkuCreateOptions();
            SkuToUpdateCreateOptions = GenerateSkuCreateOptions();
            SkuUpdateOptions = GetSkuUpdateOptions();


            var service = new StripeSkuService(Cache.ApiKey);
            SkuCreated = service.Create(SkuCreateOptions);
            var skuToUpdate = new StripeSkuService(Cache.ApiKey).Create(SkuToUpdateCreateOptions);
            SkuUpdated = service.Update(skuToUpdate.Id, SkuUpdateOptions);
        }

        private StripeSkuCreateOptions GenerateSkuCreateOptions()
        {
            var options = new StripeSkuCreateOptions
            {
                Id = Guid.NewGuid().ToString(),
                Active = true,
                Currency = "usd",
                Inventory = new StripeInventoryOptions
                {
                    Type = "infinite"
                },
                Price = 10000,
                ProductId = Product.Id,
                PackageDimensions = new StripeDimensionsOptions()
                {
                    Weight = 12,
                    Width = 12,
                    Length = 12,
                    Height = 12
                },
                Attributes = new Dictionary<string, string>
                {
                    {"color", Guid.NewGuid().ToString()},
                    {"size", Guid.NewGuid().ToString()}
                },
                Image = "http://image.com/image.jpg",
                Metadata = new Dictionary<string, string>
                {
                    {"key", "value"}
                }
            };
            return options;
        }

        private StripeSkuUpdateOptions GetSkuUpdateOptions()
        {
            var options = new StripeSkuUpdateOptions
            {
                Active = false,
                Currency = "usd",
                Inventory = new StripeInventoryOptions
                {
                    Type = "infinite"
                },
                Price = 20000,
                ProductId = Product.Id,
                PackageDimensions = new StripeDimensionsOptions
                {
                    Weight = 10,
                    Width = 10,
                    Length = 10,
                    Height = 10
                },
                Attributes = new Dictionary<string, string>
                {
                    {"color", "blue" },
                    {"size", "small" }
                },
                Image = "http://image.com/image.jpg",
                Metadata = new Dictionary<string, string>
                {
                    {"key-update", "value-update"}
                }
            };

            return options;
        }

        public void Dispose()
        {
            new StripeSkuService(Cache.ApiKey).Delete(SkuCreated.Id);
        }
    }
}
