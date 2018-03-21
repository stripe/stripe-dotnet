using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_listing_skus : IClassFixture<skus_fixture>
    {
        private readonly skus_fixture fixture;
        StripeList<StripeSku> result;

        public when_listing_skus(skus_fixture fixture)
        {
            this.fixture = fixture;
            result = fixture.SkuList;
        }


        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeSku> enumerable = result as IEnumerable<StripeSku>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(result.ToList().Count > 0, true);
            Assert.Equal(result.ToList().Count, count);

        }

        [Fact]
        public void list_contents_equal()
        {

            var datahash = new HashSet<String>();
            foreach (var obj in result.Data)
            {
                datahash.Add(obj.Id);
            }

            var enumhash = new HashSet<String>();
            IEnumerable<StripeSku> enumerable = result as IEnumerable<StripeSku>;
            foreach (var obj in enumerable)
            {
                enumhash.Add(obj.Id);
            }

            Assert.Equal(datahash, enumhash);

        }

        [Fact]
        public void list_contains_extra_attributes()
        {
            Assert.NotNull(result.Object);
            Assert.Equal(result.Object, "list");
            Assert.NotNull(result.Data);
            Assert.NotNull(result.Url);
        }

        [Fact]
        public void list_has_the_expected_sku()
        {
            fixture.SkuList.Data.Count.Should().Be(1);
            fixture.SkuList.Data.First().Id.Should().Be(fixture.SkuTwo.Id);
            fixture.SkuList.Data.First().ProductId.Should().Be(fixture.Product.Id);
        }
    }
}
