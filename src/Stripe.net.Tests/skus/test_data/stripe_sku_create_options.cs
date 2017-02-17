using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public class stripe_sku_create_options
    {
        public static StripeSkuCreateOptions Valid(string productId)
        {
            return new StripeSkuCreateOptions()
            {
                Active = true,
                Attributes = new Dictionary<string, string>()
                                 {
                                     {"size", "M"},
                                     {"color", "green"}
                                 },
                Currency = "aud",
                Id = "test_sku_" + Guid.NewGuid().ToString(),
                Image = "http://url.to/image1.png",
                Inventory = new StripeInventoryOptions()
                                {
                                    Quantity = 100,
                                    Type = "finite",
                                },
                Metadata = new Dictionary<string, string>
                {
                    { "SKU-A", "SKU-Value-A" },
                    { "SKU-B", "SKU-Value-B" }
                },
                PackageDimensions = new StripeDimensionsOptions()
                {
                    Height = 10,
                    Length = 20,
                    Weight = 30,
                    Width = 40
                },
                Price = 500,
                ProductId = productId
            };
        }
    }
}
