namespace StripeTests.Issuing
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Stripe.Issuing;
    using Xunit;

    public class DisputeTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/issuing/disputes/idp_123");
            var dispute = Mapper<Stripe.Issuing.Dispute>.MapFromJson(json);
            Assert.NotNull(dispute);
            Assert.IsType<Stripe.Issuing.Dispute>(dispute);
            Assert.NotNull(dispute.Id);
            Assert.Equal("issuing.dispute", dispute.Object);
        }
    }
}
