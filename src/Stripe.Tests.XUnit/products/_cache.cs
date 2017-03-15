using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeProduct GetProduct()
        {
            if (Items.ContainsKey("product")) return (StripeProduct)Items["product"];

            var product = new StripeProductService(ApiKey).Create(GetProductCreateOptions());
            Items.Add("product", product);

            return product;
        }

        public static StripeProduct GetProductToUpdate()
        {
            if (Items.ContainsKey("product_to_update")) return (StripeProduct)Items["product_to_update"];

            var product = new StripeProductService(ApiKey).Create(GetProductToUpdateCreateOptions());
            Items.Add("product_to_update", product);

            return product;
        }

        public static StripeProductCreateOptions GetProductCreateOptions()
        {
            if (Items.ContainsKey("product_create_options")) return (StripeProductCreateOptions)Items["product_create_options"];

            var options = GenerateProductCreateOptions();
            Items.Add("product_create_options", options);

            return options;
        }

        public static StripeProductCreateOptions GetProductToUpdateCreateOptions()
        {
            if (Items.ContainsKey("product_to_update_create_options")) return (StripeProductCreateOptions)Items["product_to_update_create_options"];

            var options = GenerateProductCreateOptions();
            Items.Add("product_to_update_create_options", options);

            return options;
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
                Attributes = new[] {"color", "size"},
                Images = new[] {"http://image.com/image.jpg"},
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
            if (Items.ContainsKey("product_update_options")) return (StripeProductUpdateOptions)Items["product_update_options"];

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
            Items.Add("product_update_options", options);

            return options;
        }
    }
}
