using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public class product_fixture : IDisposable
    {
        public StripeProduct ProductCreated { get; }
        public StripeProduct ProductUpdated { get; }
        public StripeProductCreateOptions ProductCreateOptions { get; }
        public StripeProductCreateOptions ProductToUpdateCreateOptions { get; }
        public StripeProductUpdateOptions ProductUpdateOptions { get; }
        

        public product_fixture()
        {
            ProductCreateOptions = GenerateProductCreateOptions();
            ProductToUpdateCreateOptions = GenerateProductCreateOptions();
            ProductUpdateOptions = GetProductUpdateOptions();

            var service = new StripeProductService(Cache.ApiKey);
            ProductCreated = service.Create(ProductCreateOptions);
            var productToUpdate = service.Create(ProductToUpdateCreateOptions);
            ProductUpdated = service.Update(productToUpdate.Id, ProductUpdateOptions);
        }

        private static StripeProductCreateOptions GenerateProductCreateOptions()
        {
            var guidString = Guid.NewGuid().ToString();

            var options = new StripeProductCreateOptions
            {
                Name = guidString,
                Id = guidString,
                Active = true,
                Caption = guidString,
                Description = guidString,
                Shippable = true,
                PackageDimensions = new StripeDimensionsOptions
                {
                    Height = 12,
                    Length = 12,
                    Weight = 12,
                    Width = 12
                },
                Attributes = new[] { "color", "size" },
                Images = new[] { "http://image.com/image.jpg" },
                Url = "https://github.com/jaymedavis/stripe.net",
                Metadata = new Dictionary<string, string>
                {
                    {"key", "value"}
                }
            };

            return options;
        }

        public static StripeProductUpdateOptions GetProductUpdateOptions()
        {
            var options = new StripeProductUpdateOptions
            {
                Name = Guid.NewGuid().ToString(),
                PackageDimensions = new StripeDimensionsOptions()
                {
                    Width = 10,
                    Length = 10,
                    Weight = 10,
                    Height = 10
                },
                Shippable = false,
                Attributes = new[] { "color-update", "size-update" },
                Images = new[] { "http://image.com/image.jpg-update" },
                Url = "https://github.com/jaymedavis/stripe.net2-update",
                Metadata = new Dictionary<string, string>
                {
                    {"key-update", "value-update"}
                }
            };

            return options;
        }

        public void Dispose()
        {
            new StripeProductService(Cache.ApiKey).Delete(ProductUpdated.Id);
        }
    }
}
