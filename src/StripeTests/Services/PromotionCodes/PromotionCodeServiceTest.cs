namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PromotionCodeServiceTest : BaseStripeTest
    {
        private const string PromotionCodeId = "promo_123";

        private readonly PromotionCodeService service;
        private readonly PromotionCodeCreateOptions createOptions;
        private readonly PromotionCodeUpdateOptions updateOptions;
        private readonly PromotionCodeListOptions listOptions;

        public PromotionCodeServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new PromotionCodeService(this.StripeClient);

            this.createOptions = new PromotionCodeCreateOptions
            {
                Coupon = "co_123",
                Code = "TESTCODE",
            };

            this.updateOptions = new PromotionCodeUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new PromotionCodeListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var promotionCode = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes");
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var promotionCode = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes");
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }

        [Fact]
        public void Get()
        {
            var promotionCode = this.service.Get(PromotionCodeId);
            this.AssertRequest(HttpMethod.Get, "/v1/promotion_codes/promo_123");
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var promotionCode = await this.service.GetAsync(PromotionCodeId);
            this.AssertRequest(HttpMethod.Get, "/v1/promotion_codes/promo_123");
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }

        [Fact]
        public void List()
        {
            var promotionCodes = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/promotion_codes");
            Assert.NotNull(promotionCodes);
            Assert.Equal("list", promotionCodes.Object);
            Assert.Single(promotionCodes.Data);
            Assert.Equal("promotion_code", promotionCodes.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var promotionCodes = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/promotion_codes");
            Assert.NotNull(promotionCodes);
            Assert.Equal("list", promotionCodes.Object);
            Assert.Single(promotionCodes.Data);
            Assert.Equal("promotion_code", promotionCodes.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var promotionCode = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }

#if !NET45
        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var promotionCode = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }
#endif

        [Fact]
        public void Update()
        {
            var promotionCode = this.service.Update(PromotionCodeId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes/promo_123");
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var promotionCode = await this.service.UpdateAsync(PromotionCodeId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/promotion_codes/promo_123");
            Assert.NotNull(promotionCode);
            Assert.Equal("promotion_code", promotionCode.Object);
        }
    }
}
