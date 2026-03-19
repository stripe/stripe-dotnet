namespace StripeTests
{
    using System.Text.Json;
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
            var json = GetResourceAsString("api_fixtures.subscription_schedule.json");
            var schedule = JsonSerializer.Deserialize<SubscriptionSchedule>(json);
            Assert.NotNull(schedule);
            Assert.IsType<SubscriptionSchedule>(schedule);
            Assert.NotNull(schedule.Id);
            Assert.Equal("subscription_schedule", schedule.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            var json = GetResourceAsString("api_fixtures.subscription_schedule_with_expansions.json");
            var schedule = JsonSerializer.Deserialize<SubscriptionSchedule>(json);
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
