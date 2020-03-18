namespace StripeTests
{
    using System.Collections.Generic;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class CustomerUpdateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeEmptyParam()
        {
            var testCases = new[]
            {
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Address = new AddressOptions
                        {
                            Country = "US",
                        },
                    },
                    want = "address[country]=US",
                },
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Address = EmptyParam.Empty,
                    },
                    want = "address=",
                },
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Email = "stripe@example.com",
                    },
                    want = "email=stripe%40example.com",
                },
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Email = EmptyParam.Empty,
                    },
                    want = "email=",
                },
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Metadata = new Dictionary<string, string>
                        {
                            { "key", "value" },
                        },
                    },
                    want = "metadata[key]=value",
                },
                new
                {
                    options = new CustomerUpdateOptions
                    {
                        Metadata = EmptyParam.Empty,
                    },
                    want = "metadata=",
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, FormEncoder.CreateQueryString(testCase.options));
            }
        }
    }
}
