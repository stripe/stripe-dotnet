namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class ChargeCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void Serialize()
        {
            var testCases = new[]
            {
                // No data
                new
                {
                    data = new ChargeCreateOptions { },
                    want = string.Empty,
                },

                // Source is a non-null, non-empty string
                new
                {
                    data = new ChargeCreateOptions
                    {
                        Source = "tok_visa",
                    },
                    want = "source=tok_visa",
                },

                // Source is a non-null, empty string
                new
                {
                    data = new ChargeCreateOptions
                    {
                        Source = string.Empty,
                    },
                    want = "source=",
                },

                // Source is a null string
                new
                {
                    data = new ChargeCreateOptions
                    {
                        Source = (string)null,
                    },
                    want = string.Empty,
                },

                // Source is a non-null CardCreateNestedOptions
                new
                {
                    data = new ChargeCreateOptions
                    {
                        Source = new CardCreateNestedOptions
                        {
                            Number = "4242424242424242",
                            ExpMonth = 1,
                            ExpYear = 2030,
                        },
                    },
                    want = "source[object]=card&source[exp_month]=1&source[exp_year]=2030&source[number]=4242424242424242",
                },

                // Source is a null CardCreateNestedOptions
                new
                {
                    data = new ChargeCreateOptions
                    {
                        Source = (CardCreateNestedOptions)null,
                    },
                    want = string.Empty,
                },

                // Source is null
                new
                {
                    data = new ChargeCreateOptions
                    {
                        Source = null,
                    },
                    want = string.Empty,
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, FormEncoder.CreateQueryString(testCase.data));
            }
        }
    }
}
