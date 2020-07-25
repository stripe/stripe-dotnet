namespace StripeTests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PlanServiceTest : BaseStripeTest
    {
        private const string PlanId = "plan_123";

        private readonly PlanService service;
        private readonly PlanCreateOptions createOptions;
        private readonly PlanCreateOptions createDecimalTierOptions;
        private readonly PlanUpdateOptions updateOptions;
        private readonly PlanListOptions listOptions;

        public PlanServiceTest(
            StripeMockFixture stripeMockFixture,
            MockHttpClientFixture mockHttpClientFixture)
            : base(stripeMockFixture, mockHttpClientFixture)
        {
            this.service = new PlanService(this.StripeClient);

            this.createOptions = new PlanCreateOptions
            {
                AmountDecimal = 0.01234567890m, // Ensure decimals work
                Currency = "usd",
                Interval = "month",
                Nickname = "Plan Nickmame",
                Product = new PlanProductOptions
                {
                    Name = "Product Name",
                },
            };

            this.createDecimalTierOptions = new PlanCreateOptions
            {
                Currency = "usd",
                Interval = "month",
                Nickname = "Plan Nickmame",
                Product = new PlanProductOptions
                {
                    Name = "Product Name",
                },
                Tiers = new List<PlanTierOptions>
                {
                    new PlanTierOptions
                    {
                        UnitAmountDecimal = 0.04m,
                        UpTo = 10,
                    },
                    new PlanTierOptions
                    {
                        UnitAmountDecimal = 0.03m,
                        UpTo = PlanTierUpTo.Inf,
                    },
                },
            };

            this.updateOptions = new PlanUpdateOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new PlanListOptions
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var plan = this.service.Create(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void Create_DecimalTiers()
        {
            var plan = this.service.Create(this.createDecimalTierOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task CreateAsync_DecimalTiers()
        {
            var plan = await this.service.CreateAsync(this.createDecimalTierOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var plan = await this.service.CreateAsync(this.createOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/plans");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(PlanId);
            this.AssertRequest(HttpMethod.Delete, "/v1/plans/plan_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(PlanId);
            this.AssertRequest(HttpMethod.Delete, "/v1/plans/plan_123");
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var plan = this.service.Get(PlanId);
            this.AssertRequest(HttpMethod.Get, "/v1/plans/plan_123");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var plan = await this.service.GetAsync(PlanId);
            this.AssertRequest(HttpMethod.Get, "/v1/plans/plan_123");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void List()
        {
            var plans = this.service.List(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/plans");
            Assert.NotNull(plans);
            Assert.Equal("list", plans.Object);
            Assert.Single(plans.Data);
            Assert.Equal("plan", plans.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var plans = await this.service.ListAsync(this.listOptions);
            this.AssertRequest(HttpMethod.Get, "/v1/plans");
            Assert.NotNull(plans);
            Assert.Equal("list", plans.Object);
            Assert.Single(plans.Data);
            Assert.Equal("plan", plans.Data[0].Object);
        }

        [Fact]
        public void ListAutoPaging()
        {
            var plan = this.service.ListAutoPaging(this.listOptions).First();
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task ListAutoPagingAsync()
        {
            var plan = await this.service.ListAutoPagingAsync(this.listOptions).FirstAsync();
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void Update()
        {
            var plan = this.service.Update(PlanId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/plans/plan_123");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var plan = await this.service.UpdateAsync(PlanId, this.updateOptions);
            this.AssertRequest(HttpMethod.Post, "/v1/plans/plan_123");
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }
    }
}
