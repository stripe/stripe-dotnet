using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.XUnit
{


    public class when_listing_events
    {

        StripeList<StripeEvent> result;

        public when_listing_events()
        {

            Cache.GetCustomer();
            Cache.GetCustomer();
            Cache.GetCustomer();
            Cache.GetCustomer();
            result = new StripeEventService(Cache.ApiKey).List(new StripeEventListOptions { Limit = 3 });

        }



        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeEvent> enumerable = result as IEnumerable<StripeEvent>;
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
            IEnumerable<StripeEvent> enumerable = result as IEnumerable<StripeEvent>;
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
