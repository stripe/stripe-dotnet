using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class adding_a_plan_to_a_product : IClassFixture<add_plan_to_product_fixture>
    {
        private readonly add_plan_to_product_fixture fixture;

        public adding_a_plan_to_a_product(add_plan_to_product_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void has_the_right_product()
        {
            fixture.Plan.ProductId.Should().Be(fixture.Product.Id);
            fixture.PlanRetrieved.ProductId.Should().Be(fixture.Product.Id);
        }
    }
}
