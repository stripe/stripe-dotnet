using System.Collections.Generic;
using System.Linq;
using System;
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

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeCharge> enumerable = fixture.Charges as IEnumerable<StripeCharge>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(fixture.Charges.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in fixture.Charges.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeCharge> enumerable = fixture.Charges as IEnumerable<StripeCharge>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(fixture.Charges.Object);
            Assert.Equal(fixture.Charges.Object, "list");
            Assert.NotNull(fixture.Charges.Data);
            Assert.NotNull(fixture.Charges.Url);
        }

    }
}
