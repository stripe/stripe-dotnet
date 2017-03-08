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
    }
}
