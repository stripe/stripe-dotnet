namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class DiscountTest : BaseStripeTest
    {
        public DiscountTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.discount.json");
            var discount = JsonConvert.DeserializeObject<Discount>(json);

            Assert.NotNull(discount);
            Assert.Equal("discount", discount.Object);
            Assert.NotNull(discount.Coupon);
            Assert.Equal("coupon", discount.Coupon.Object);
        }
    }
}
