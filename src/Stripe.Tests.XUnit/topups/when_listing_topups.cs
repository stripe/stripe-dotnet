using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.XUnit
{
    public class when_listing_topups : IClassFixture<topups_fixture>
    {
        private readonly topups_fixture fixture;
        private StripeList<StripeTopup> result;

        public when_listing_topups(topups_fixture topupsFixture)
        {
            fixture = topupsFixture;
            result = fixture.TopupList;
        }
        
        [Fact(Skip="Feature is private beta and tests are non-deterministic")]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeTopup> enumerable = result as IEnumerable<StripeTopup>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(result.ToList().Count > 0, true);
            Assert.Equal(result.ToList().Count, count);

        }

        [Fact(Skip="Feature is private beta and tests are non-deterministic")]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in result.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeTopup> enumerable = result as IEnumerable<StripeTopup>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact(Skip="Feature is private beta and tests are non-deterministic")]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(result.Object);
            Assert.Equal(result.Object, "list");
            Assert.NotNull(result.Data);
            Assert.NotNull(result.Url);
        }

    }
}
