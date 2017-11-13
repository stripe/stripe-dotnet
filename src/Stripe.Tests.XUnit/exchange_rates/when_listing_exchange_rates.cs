using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.XUnit
{
    public class when_listing_exchange_rates
    {
        StripeList<StripeExchangeRate> result;

        public when_listing_exchange_rates()
        {
            result = new StripeExchangeRateService(Cache.ApiKey).List(new StripeExchangeRateListOptions { Limit = 3 });
        }

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeExchangeRate> enumerable = result as IEnumerable<StripeExchangeRate>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(result.ToList().Count, 3);
            Assert.Equal(result.ToList().Count, count);
        }
    }
}
