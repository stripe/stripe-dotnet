namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class PlanTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/plans/plan_123");
            var plan = Mapper<Plan>.MapFromJson(json);
            Assert.NotNull(plan);
            Assert.IsType<Plan>(plan);
            Assert.NotNull(plan.Id);
            Assert.Equal("plan", plan.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "product",
            };

            string json = GetFixture("/v1/plans/plan_123", expansions);
            var plan = Mapper<Plan>.MapFromJson(json);
            Assert.NotNull(plan);
            Assert.IsType<Plan>(plan);
            Assert.NotNull(plan.Id);
            Assert.Equal("plan", plan.Object);

            Assert.NotNull(plan.Product);
            Assert.Equal("product", plan.Product.Object);
        }
    }
}
