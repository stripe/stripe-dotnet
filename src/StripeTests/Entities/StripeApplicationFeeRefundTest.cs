namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeApplicationFeeRefundTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/application_fees/fee_123/refunds/fr_123");
            var applicationFeeRefund = Mapper<StripeApplicationFeeRefund>.MapFromJson(json);
            Assert.NotNull(applicationFeeRefund);
            Assert.IsType<StripeApplicationFeeRefund>(applicationFeeRefund);
            Assert.NotNull(applicationFeeRefund.Id);
            Assert.Equal("fee_refund", applicationFeeRefund.Object);
        }
    }
}
