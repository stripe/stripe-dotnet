namespace StripeTests.Issuing
{
    using Newtonsoft.Json;
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
            var dispute = JsonConvert.DeserializeObject<Dispute>(json);
            Assert.NotNull(dispute);
            Assert.IsType<Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("issuing.dispute", dispute.Object);
        }
    }
}
