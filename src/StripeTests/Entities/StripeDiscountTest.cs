namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class StripeDiscountTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.discount.json");
            var discount = Mapper<StripeDiscount>.MapFromJson(json);

            Assert.NotNull(discount);
            Assert.Equal("discount", discount.Object);
            Assert.NotNull(discount.StripeCoupon);
            Assert.Equal("coupon", discount.StripeCoupon.Object);
        }
    }
}
