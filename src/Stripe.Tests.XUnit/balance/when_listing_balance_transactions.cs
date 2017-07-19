using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.XUnit
{
    public class when_listing_balance_transactions
    {

        StripeList<StripeBalanceTransaction> result;

        public when_listing_balance_transactions()
        {
            // todo: minimize this happening every time. it only needs 4 charges present to test the list

            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);
            Cache.GetStripeCharge(Cache.ApiKey);

            result = new StripeBalanceService(Cache.ApiKey).List();

        }

        [Fact]
        public void it_should_have_the_count()
        {
            result.Data.Count.Should().BeGreaterOrEqualTo(4);
        }


        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeBalanceTransaction> enumerable = result as IEnumerable<StripeBalanceTransaction>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
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
            IEnumerable<StripeBalanceTransaction> enumerable = result as IEnumerable<StripeBalanceTransaction>;
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
