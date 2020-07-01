namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class CouponServiceTest : BaseStripeTest
    {
        private const string CouponId = "co_123";

        private readonly CouponService service;
        private readonly CouponCreateOptions createOptions;
        private readonly CouponUpdateOptions updateOptions;
        private readonly CouponListOptions listOptions;

        public CouponServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new CouponService(this.StripeClient);

            this.createOptions = new CouponCreateOptions
            {
                PercentOff = 25,
                Duration = "forever",
            };

            this.updateOptions = new CouponUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new CouponListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var coupon = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons");
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var coupon = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons");
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(CouponId);
            this.AssertRequest(HttpMethod.Delete, "/v1/coupons/co_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(CouponId);
            this.AssertRequest(HttpMethod.Delete, "/v1/coupons/co_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var coupon = this.service.Get(CouponId);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons/co_123");
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var coupon = await this.service.GetAsync(CouponId);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons/co_123");
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public void List()
        {
            var coupons = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons");
            Assert.NotNull(coupons);
            Assert.Equal("list", coupons.Object);
            Assert.Single(coupons.Data);
            Assert.Equal("coupon", coupons.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var coupons = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/coupons");
            Assert.NotNull(coupons);
            Assert.Equal("list", coupons.Object);
            Assert.Single(coupons.Data);
            Assert.Equal("coupon", coupons.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var coupon = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var coupon = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public void Update()
        {
            var coupon = this.service.Update(CouponId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons/co_123");
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var coupon = await this.service.UpdateAsync(CouponId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/coupons/co_123");
            Assert.NotNull(coupon);
            Assert.Equal("coupon", coupon.Object);
        }
    }
}
