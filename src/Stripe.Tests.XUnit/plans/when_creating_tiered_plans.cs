using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_tiered_plans : IClassFixture<tiered_plan_fixture>
    {
        private readonly tiered_plan_fixture fixture;

        public creating_tiered_plans(tiered_plan_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void has_the_correct_billing_scheme()
        {
            fixture.Plan.BillingScheme.Should().Be(fixture.PlanCreateOptions.BillingScheme);
        }

        [Fact]
        public void has_the_correct_tiers_mode()
        {
            fixture.Plan.TiersMode.Should().Be(fixture.PlanCreateOptions.TiersMode);
        }

        [Fact]
        public void has_the_correct_first_tier()
        {
            fixture.Plan.Tiers[0].Amount.Should().Be(fixture.PlanCreateOptions.Tiers[0].Amount);

            StripePlanTierOptions.UpToOption upTo = fixture.PlanCreateOptions.Tiers[0].UpTo;
            StripePlanTierOptions.UpToBound upBound = (StripePlanTierOptions.UpToBound) upTo;
            fixture.Plan.Tiers[0].UpTo.Should().Be(upBound.Bound);
        }

        [Fact]
        public void has_the_correct_second_tier()
        {
            fixture.Plan.Tiers[1].Amount.Should().Be(fixture.PlanCreateOptions.Tiers[1].Amount);
            fixture.Plan.Tiers[1].UpTo.Should().Be(null);
        }
    }
}
