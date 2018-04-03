using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_transform_usage_plans : IClassFixture<transform_usage_plan_fixture>
    {
        private readonly transform_usage_plan_fixture fixture;

        public creating_transform_usage_plans(transform_usage_plan_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void has_the_currect_divide_by()
        {
            fixture.Plan.TransformUsage.DivideBy.Should().Be(fixture.PlanCreateOptions.TransformUsage.DivideBy);
        }

        [Fact]
        public void has_the_currect_rouding()
        {
            fixture.Plan.TransformUsage.Round.Should().Be(fixture.PlanCreateOptions.TransformUsage.Round);
        }
    }
}
