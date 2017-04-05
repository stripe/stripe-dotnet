using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class listing_charges_with_include_all : IClassFixture<charges_fixture>
    {
        private readonly charges_fixture fixture;

        public listing_charges_with_include_all(charges_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void list_is_not_null()
        {
            fixture.Charges.Should().NotBeNull();
        }

        [Fact]
        public void list_has_total_count()
        {
            fixture.Charges.TotalCount.Should().BeGreaterThan(0);
        }
    }
}
