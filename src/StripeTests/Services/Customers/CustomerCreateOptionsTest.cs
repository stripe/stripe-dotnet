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
                        TrialEnd = DateTime.Parse("Fri, 13 Feb 2009 23:31:30Z"),
                    },
                    want = "trial_end=1234567890",
                },
                new
                {
                    options = new CustomerCreateOptions
                    {
                        TrialEnd = SubscriptionTrialEnd.Now,
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
