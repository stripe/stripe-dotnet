using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_sources : IClassFixture<sources_fixture>
    {
        private readonly sources_fixture fixture;

        public creating_and_updating_sources(sources_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Source.Should().NotBeNull();
        }

        [Fact]
        public void created_has_the_right_owner_email()
        {
            fixture.Source.Owner.Email.Should().Be(fixture.SourceCreateOptions.Owner.Email);
        }

        [Fact]
        public void created_address_is_not_null()
        {
            fixture.Source.Owner.Address.Should().NotBeNull();
        }

        [Fact]
        public void created_has_the_right_owner_city()
        {
            fixture.Source.Owner.Address.City.Should().Be(fixture.SourceCreateOptions.Owner.CityOrTown);
        }

        [Fact]
        public void created_has_the_right_owner_state()
        {
            fixture.Source.Owner.Address.State.Should().Be(fixture.SourceCreateOptions.Owner.State);
        }

        [Fact]
        public void updated_has_the_right_owner_email()
        {
            fixture.SourceUpdated.Owner.Email.Should().Be(fixture.SourceUpdateOptions.Owner.Email);
        }

        [Fact]
        public void retrieved_is_not_null()
        {
            fixture.SourceRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void retrieved_owner_email_is_not_null()
        {
            fixture.SourceRetrieved.Owner.Should().NotBeNull();
        }
    }
}
