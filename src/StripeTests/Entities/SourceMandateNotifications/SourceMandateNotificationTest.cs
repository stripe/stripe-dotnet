namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class SourceMandateNotificationTest : BaseStripeTest
    {
        public SourceMandateNotificationTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.source_mandate_notification.json");
            var mandate = JsonConvert.DeserializeObject<SourceMandateNotification>(json);
            Assert.NotNull(mandate);
            Assert.IsType<SourceMandateNotification>(mandate);
            Assert.NotNull(mandate.Id);
            Assert.Equal("source_mandate_notification", mandate.Object);
        }
    }
}
