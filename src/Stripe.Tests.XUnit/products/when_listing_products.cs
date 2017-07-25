using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_listing_products : IClassFixture<products_fixture>
    {
        private readonly products_fixture fixture;
        StripeList<StripeProduct> result;

        public when_listing_products(products_fixture fixture)
        {
            this.fixture = fixture;
            result = fixture.ProductList;
        }


        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeProduct> enumerable = result as IEnumerable<StripeProduct>;
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
            IEnumerable<StripeProduct> enumerable = result as IEnumerable<StripeProduct>;
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
    }
}
