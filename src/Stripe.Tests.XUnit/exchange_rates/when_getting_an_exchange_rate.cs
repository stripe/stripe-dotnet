using FluentAssertions;
using Stripe.Tests.Xunit;
using System.Collections.Generic;
using System;
using System.Linq;
using Xunit;

namespace Stripe.Tests.XUnit
{
    public class when_getting_an_exchange_rate
    {
        StripeExchangeRate result;

        public when_getting_an_exchange_rate()
        {
            result = new StripeExchangeRateService(Cache.ApiKey).Get("usd");
        }

        [Fact]
        public void it_should_have_rates()
        {
            result.Rates.Should().NotBeNull();
            result.Rates.Should().NotBeEmpty();
        }

        [Fact]
        public void it_should_have_rate_for_eur()
        {
            result.Rates["eur"].Should().BeGreaterThan(0);
        }
    }
}
