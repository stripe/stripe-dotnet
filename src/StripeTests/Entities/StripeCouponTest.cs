namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeCouponTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/coupons/co_123");
            var coupon = Mapper<StripeCoupon>.MapFromJson(json);
            Assert.NotNull(coupon);
            Assert.IsType<StripeCoupon>(coupon);
            Assert.NotNull(coupon.Id);
            Assert.Equal("coupon", coupon.Object);
        }
    }
}
