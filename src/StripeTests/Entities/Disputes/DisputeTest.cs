namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class DisputeTest : BaseStripeTest
    {
        public DisputeTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/disputes/dp_123");
            var dispute = JsonConvert.DeserializeObject<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("dispute", dispute.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "charge",
            };

            string json = this.GetFixture("/v1/disputes/dp_123", expansions);
            var dispute = JsonConvert.DeserializeObject<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("dispute", dispute.Object);

            Assert.NotNull(dispute.Charge);
            Assert.Equal("charge", dispute.Charge.Object);
        }
    }
}
