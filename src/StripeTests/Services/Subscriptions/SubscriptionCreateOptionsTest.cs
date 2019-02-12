namespace StripeTests
{
    using System.Collections.Generic;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class SubscriptionCreateOptionsTest : BaseStripeTest
    {
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

            Assert.Equal(
                "customer=cus_123&" +
                "items[0][plan]=plan_123&items[0][quantity]=2&" +
                "items[1][plan]=plan_124&items[1][quantity]=3",
                FormEncoder.CreateQueryString(options));
        }
    }
}
