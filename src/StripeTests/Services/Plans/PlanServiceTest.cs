namespace StripeTests
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Stripe;
    using Xunit;

    public class PlanServiceTest : BaseStripeTest
    {
        private const string PlanId = "plan_123";

        private PlanService service;
        private PlanCreateOptions createOptions;
        private PlanUpdateOptions updateOptions;
        private PlanListOptions listOptions;

        public PlanServiceTest()
        {
            this.service = new PlanService();

            this.createOptions = new PlanCreateOptions()
            {
                Amount = 123,
                Currency = "usd",
                Interval = "month",
                Nickname = "Plan Nickmame",
                Product = new PlanProductCreateOptions
                {
                    Name = "Product Name",
                },
            };

            this.updateOptions = new PlanUpdateOptions()
            {
                Metadata = new Dictionary<string, string>()
                {
                    { "key", "value" },
                },
            };

            this.listOptions = new PlanListOptions()
            {
                Limit = 1,
            };
        }

        [Fact]
        public void Create()
        {
            var plan = this.service.Create(this.createOptions);
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task CreateAsync()
        {
            var plan = await this.service.CreateAsync(this.createOptions);
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void Delete()
        {
            var deleted = this.service.Delete(PlanId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public async Task DeleteAsync()
        {
            var deleted = await this.service.DeleteAsync(PlanId);
            Assert.NotNull(deleted);
        }

        [Fact]
        public void Get()
        {
            var plan = this.service.Get(PlanId);
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task GetAsync()
        {
            var plan = await this.service.GetAsync(PlanId);
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void List()
        {
            var plans = this.service.List(this.listOptions);
            Assert.NotNull(plans);
            Assert.Equal("list", plans.Object);
            Assert.Single(plans.Data);
            Assert.Equal("plan", plans.Data[0].Object);
        }

        [Fact]
        public async Task ListAsync()
        {
            var plans = await this.service.ListAsync(this.listOptions);
            Assert.NotNull(plans);
            Assert.Equal("list", plans.Object);
            Assert.Single(plans.Data);
            Assert.Equal("plan", plans.Data[0].Object);
        }

        [Fact]
        public void Update()
        {
            var plan = this.service.Update(PlanId, this.updateOptions);
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public async Task UpdateAsync()
        {
            var plan = await this.service.UpdateAsync(PlanId, this.updateOptions);
            Assert.NotNull(plan);
            Assert.Equal("plan", plan.Object);
        }
    }
}
