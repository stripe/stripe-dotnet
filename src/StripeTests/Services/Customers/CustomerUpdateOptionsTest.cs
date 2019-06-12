namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class CustomerUpdateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeShipping()
        {
            var testCases = new[]
            {
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Shipping = new ShippingOptions
                        {
                            Name = "Jenny Rosen",
                        }
                    },
                    want = "shipping[name]=Jenny+Rosen",
                },
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Shipping = EmptyValue.Empty,
                    },
                    want = "shipping=",
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, FormEncoder.CreateQueryString(testCase.options));
            }
        }
    }
}
