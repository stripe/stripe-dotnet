namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class SubscriptionCreateOptionsTest : BaseStripeTest
    {
        [Fact]
        public void SerializeItems()
        {
            var options = new SubscriptionCreateOptions
            {
                CustomerId = "cus_123",
                Items = new List<SubscriptionItemOption>
                {
                    new SubscriptionItemOption
                    {
                        PlanId = "plan_123",
                        Quantity = 2
                    },
                    new SubscriptionItemOption
                    {
                        PlanId = "plan_124",
                        Quantity = 3
                    },
                },
            };

            Assert.Equal(
                "customer=cus_123&" +
                "items[0][plan]=plan_123&items[0][quantity]=2&" +
                "items[1][plan]=plan_124&items[1][quantity]=3",
                FormEncoder.CreateQueryString(options));
        }

        [Fact]
        public void SerializeTrialEndDateTime()
        {
            var options = new SubscriptionCreateOptions
            {
                TrialEnd = DateTime.Parse("Fri, 13 Feb 2009 23:31:30Z"),
            };

            Assert.Equal("trial_end=1234567890", FormEncoder.CreateQueryString(options));
        }

        [Fact]
        public void SerializeTrialEndNow()
        {
            var options = new SubscriptionCreateOptions
            {
                TrialEnd = SubscriptionTrialEnd.Now,
            };

            Assert.Equal("trial_end=now", FormEncoder.CreateQueryString(options));
        }
    }
}
