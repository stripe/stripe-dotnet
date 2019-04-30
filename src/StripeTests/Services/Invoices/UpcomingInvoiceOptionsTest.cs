namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class UpcomingInvoiceOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeSubscriptionBillingCycleAnchor()
        {
            var testCases = new[]
            {
                new
                {
                    options = new UpcomingInvoiceOptions
                    {
                        SubscriptionBillingCycleAnchor = DateTime.Parse("Fri, 13 Feb 2009 23:31:30Z"),
                    },
                    want = "subscription_billing_cycle_anchor=1234567890",
                },
                new
                {
                    options = new UpcomingInvoiceOptions
                    {
                        SubscriptionBillingCycleAnchor = SubscriptionBillingCycleAnchor.Now,
                    },
                    want = "subscription_billing_cycle_anchor=now",
                },
                new
                {
                    options = new UpcomingInvoiceOptions
                    {
                        SubscriptionBillingCycleAnchor = SubscriptionBillingCycleAnchor.Unchanged,
                    },
                    want = "subscription_billing_cycle_anchor=unchanged",
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, FormEncoder.CreateQueryString(testCase.options));
            }
        }
    }
}
