using System;
using System.Collections.Generic;

namespace Stripe.Tests.Xunit
{
    public static partial class Cache
    {
        public static StripeSku GetSku()
        {
            if (Items.ContainsKey("sku")) return (StripeSku)Items["sku"];

            var sku = new StripeSkuService(ApiKey).Create(GetSkuCreateOptions());
            Items.Add("sku", sku);

            return sku;
        }

        public static StripeSku GetSkuToUpdate()
        {
            if (Items.ContainsKey("sku_to_update")) return (StripeSku)Items["sku_to_update"];

            var sku = new StripeSkuService(ApiKey).Create(GetSkuToUpdateCreateOptions());
            Items.Add("sku_to_update", sku);

            return sku;
        }

        public static StripeSkuCreateOptions GetSkuCreateOptions()
        {
            if (Items.ContainsKey("sku_create_options")) return (StripeSkuCreateOptions)Items["sku_create_options"];

            var options = GenerateSkuCreateOptions();

            Items.Add("sku_create_options", options);

            return options;
        }

        public static StripeSkuCreateOptions GetSkuToUpdateCreateOptions()
        {
            if (Items.ContainsKey("sku_to_update_create_options")) return (StripeSkuCreateOptions)Items["sku_to_update_create_options"];

            var options = GenerateSkuCreateOptions();

            Items.Add("sku_to_update_create_options", options);

            return options;
        }

        private static StripeSkuCreateOptions GenerateSkuCreateOptions()
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
                ProductId = GetProduct().Id,
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


        public static StripeSkuUpdateOptions GetSkuUpdateOptions()
        {
            if (Items.ContainsKey("sku_update_options")) return (StripeSkuUpdateOptions)Items["sku_update_options"];

            var options = new StripeSkuUpdateOptions
            {
                Active = false,
                Currency = "usd",
                Inventory = new StripeInventoryOptions
                {
                    Type = "infinite"
                },
                Price = 20000,
                ProductId = GetProduct().Id,
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

            Items.Add("sku_update_options", options);

            return options;
        }
    }
}
