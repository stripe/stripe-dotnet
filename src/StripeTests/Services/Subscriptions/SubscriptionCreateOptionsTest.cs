namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Stripe.Infrastructure;
    using Xunit;

    public class SubscriptionCreateOptionsTest : BaseStripeTest
    {
        private readonly SubscriptionService service;

        public SubscriptionCreateOptionsTest()
        {
            this.service = new SubscriptionService();
        }

        [Fact]
        public void Serialize()
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

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal(
                "?customer=cus_123" +
                "&items[0][plan]=plan_123&items[0][quantity]=2" +
                "&items[1][plan]=plan_124&items[1][quantity]=3",
                url);
        }
    }
}
