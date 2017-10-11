using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_plans : IClassFixture<plans_fixture>
    {
        private readonly plans_fixture fixture;

        public creating_and_updating_plans(plans_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_has_the_right_details()
        {
            fixture.Plan.Id.Should().Be(fixture.PlanCreateOptions.Id);
            fixture.Plan.Name.Should().Be(fixture.PlanCreateOptions.Name);
            fixture.Plan.Amount.Should().Be(fixture.PlanCreateOptions.Amount);
            fixture.Plan.Currency.Should().Be(fixture.PlanCreateOptions.Currency);
            fixture.Plan.Interval.Should().Be(fixture.PlanCreateOptions.Interval);
        }

        [Fact]
        public void updated_has_the_right_details()
        {
            fixture.PlanUpdated.Id.Should().Be(fixture.Plan.Id);
            fixture.PlanUpdated.Name.Should().BeEquivalentTo(fixture.PlanUpdateOptions.Name);
        }

        [Fact]
        public void retrieved_has_the_right_id()
        {
            fixture.PlanRetrieved.Id.Should().Be(fixture.Plan.Id);
        }

        [Fact]
        public void deleted_has_the_right_details()
        {
            fixture.PlanDeleted.Id.Should().Be(fixture.Plan.Id);
            fixture.PlanDeleted.Deleted.Should().Be(true);
        }
    }
}
