namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ApplicationFeeRefundTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/application_fees/fee_123/refunds/fr_123");
            var applicationFeeRefund = JsonConvert.DeserializeObject<ApplicationFeeRefund>(json);
            Assert.NotNull(applicationFeeRefund);
            Assert.IsType<ApplicationFeeRefund>(applicationFeeRefund);
            Assert.NotNull(applicationFeeRefund.Id);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }
    }
}
