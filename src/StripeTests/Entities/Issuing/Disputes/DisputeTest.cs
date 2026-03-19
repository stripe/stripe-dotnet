namespace StripeTests.Issuing
{
    using System.Text.Json;
    using Stripe.Issuing;
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
            string json = this.GetFixture("/v1/issuing/disputes/idp_123");
            var dispute = JsonSerializer.Deserialize<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("issuing.dispute", dispute.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "transaction",
            };

            string json = this.GetFixture("/v1/issuing/disputes/idp_123", expansions);
            var dispute = JsonSerializer.Deserialize<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("issuing.dispute", dispute.Object);

            Assert.NotNull(dispute.Transaction);
            Assert.Equal("issuing.transaction", dispute.Transaction.Object);
        }
    }
}
