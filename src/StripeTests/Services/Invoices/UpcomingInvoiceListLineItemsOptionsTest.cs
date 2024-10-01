namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class UpcomingInvoiceListLineItemsOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeSubscriptionBillingCycleAnchor()
        {
            var testCases = new[]
            {
                new
                {
                    options = new InvoiceUpcomingLinesListOptions()
                    {
                        SubscriptionBillingCycleAnchor = DateTime.Parse("Fri, 13 Feb 2009 23:31:30Z"),
                    },
                    want = "subscription_billing_cycle_anchor=1234567890",
                },
                new
                {
                    options = new InvoiceUpcomingLinesListOptions
                    {
                        SubscriptionBillingCycleAnchor = SubscriptionBillingCycleAnchor.Now,
                    },
                    want = "subscription_billing_cycle_anchor=now",
                },
                new
                {
                    options = new InvoiceUpcomingLinesListOptions
                    {
                        SubscriptionBillingCycleAnchor = SubscriptionBillingCycleAnchor.Unchanged,
                    },
                    want = "subscription_billing_cycle_anchor=unchanged",
                },
                new
                {
                    options = new InvoiceUpcomingLinesListOptions
                    {
                        SubscriptionTrialEnd = DateTime.Parse("Fri, 13 Feb 2009 23:31:30Z"),
                    },
                    want = "subscription_trial_end=1234567890",
                },
                new
                {
                    options = new InvoiceUpcomingLinesListOptions
                    {
                        SubscriptionTrialEnd = SubscriptionTrialEnd.Now,
                    },
                    want = "subscription_trial_end=now",
                },
            };

            foreach (var testCase in testCases)
            {
                Assert.Equal(testCase.want, ContentEncoder.CreateQueryString(testCase.options));
            }
        }
    }
}
