using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_topups : IClassFixture<topups_fixture>
    {
        private readonly topups_fixture fixture;

        public creating_and_updating_topups(topups_fixture topupsFixture)
        {
            fixture = topupsFixture;
        }

        [Fact(Skip="Feature is private beta and tests are non-deterministic")]
        public void created_has_right_details()
        {
            fixture.Topup.Should().NotBeNull();
            fixture.Topup.Id.Should().StartWith("tu_");
            fixture.Topup.Amount.Should().Be(fixture.TopupCreateOptions.Amount);
            fixture.Topup.Currency.Should().Be(fixture.TopupCreateOptions.Currency);
            fixture.Topup.Description.Should().Be(fixture.TopupCreateOptions.Description);
            fixture.Topup.StatementDescriptor.Should().Be(fixture.TopupCreateOptions.StatementDescriptor);
        }

        [Fact(Skip="Feature is private beta and tests are non-deterministic")]
        public void get_is_not_null()
        {
            fixture.TopupRetrieved.Should().NotBeNull();
            fixture.TopupRetrieved.Id.Should().Be(fixture.Topup.Id);
            fixture.TopupRetrieved.Amount.Should().Be(fixture.Topup.Amount);
            fixture.TopupRetrieved.Currency.Should().Be(fixture.Topup.Currency);
        }

        [Fact(Skip="Feature is private beta and tests are non-deterministic")]
        public void updated_has_the_right_metadata()
        {
            fixture.TopupUpdated.Metadata.Keys.Should().BeEquivalentTo(fixture.TopupUpdateOptions.Metadata.Keys);
        }
    }
}
