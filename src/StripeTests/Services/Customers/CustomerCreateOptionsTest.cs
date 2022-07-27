namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class CustomerCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeTrialEnd()
        {
            var testCases = new[]
            {
                new
                {
                    options = new CustomerCreateOptions
                    {
                    },
                    want = "trial_end=1234567890",
                },
                new
                {
                    options = new CustomerCreateOptions
                    {
                    },
                    want = "trial_end=now",
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, FormEncoder.CreateQueryString(testCase.options));
            }
        }
    }
}
