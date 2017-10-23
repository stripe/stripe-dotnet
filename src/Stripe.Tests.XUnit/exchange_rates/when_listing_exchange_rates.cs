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
        StripeList<StripeExchangeRates> result;

        public when_listing_exchange_rates()
        {
            result = new StripeExchangeRatesService(Cache.ApiKey).List(new StripeListOptions { Limit = 3 });
        }

        [Fact]
        public void list_is_iterable()
        {
            var count = 0;
            IEnumerable<StripeExchangeRates> enumerable = result as IEnumerable<StripeExchangeRates>;
            foreach (var obj in enumerable)
            {
                count += 1;
            }
            Assert.Equal(result.ToList().Count, 3);
            Assert.Equal(result.ToList().Count, count);
        }
    }
}
