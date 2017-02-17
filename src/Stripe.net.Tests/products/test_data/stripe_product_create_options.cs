using System;
using System.Collections.Generic;

namespace Stripe.Tests.test_data
{
    public static class stripe_product_create_options
    {
        public static StripeProductCreateOptions Valid()
        {
            return new StripeProductCreateOptions()
            {
                Id = "test-product-" + Guid.NewGuid(),
                Attributes = new []{"size", "color"},
                Active = true,
                Caption = "Test product caption",
                Description = "Test product description",
                Images = new []{ "http://url.to/image1.png", "http://url.to/image2.png"},
                Metadata = new Dictionary<string, string>
                {
                    { "A", "Value-A" },
                    { "B", "Value-B" }
                },
                Name = "Test Product",
                PackageDimensions = new StripeDimensionsOptions()
                                        {
                                            Height = 10,
                                            Length = 20,
                                            Weight = 30,
                                            Width = 40
                                        },
                Shippable = true,
                Url = "http://url.to/test_product/"
            };
        }
    }
}
