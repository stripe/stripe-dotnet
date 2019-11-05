namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SubscriptionScheduleTest : BaseStripeTest
    {
        public SubscriptionScheduleTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/subscription_schedules/sub_sched_123");
            var schedule = JsonConvert.DeserializeObject<SubscriptionSchedule>(json);
            Assert.NotNull(schedule);
            Assert.IsType<SubscriptionSchedule>(schedule);
            Assert.NotNull(schedule.Id);
            Assert.Equal("subscription_schedule", schedule.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            // TODO: support expanding "phases.coupon" and "phases.plans.plan" and others with stripe-mock
            string[] expansions =
            {
              "customer",
              "default_settings.default_payment_method",
              "phases.plans.plan",
              "subscription",
            };

            string json = this.GetFixture("/v1/subscription_schedules/sub_sched_123", expansions);
            var schedule = JsonConvert.DeserializeObject<SubscriptionSchedule>(json);
            Assert.NotNull(schedule);
            Assert.IsType<SubscriptionSchedule>(schedule);
            Assert.NotNull(schedule.Id);
            Assert.Equal("subscription_schedule", schedule.Object);

            Assert.NotNull(schedule.Customer);
            Assert.Equal("customer", schedule.Customer.Object);

            Assert.NotNull(schedule.DefaultSettings.DefaultPaymentMethod);
            Assert.Equal("payment_method", schedule.DefaultSettings.DefaultPaymentMethod.Object);

            Assert.NotNull(schedule.Subscription);
            Assert.Equal("subscription", schedule.Subscription.Object);
        }
    }
}
