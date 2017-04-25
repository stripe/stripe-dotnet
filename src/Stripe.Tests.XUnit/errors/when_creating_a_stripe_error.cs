using System;
using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_creating_a_stripe_error
    {
        [Fact]
        public void should_have_stripe_response()
        {
            var exception = Assert.Throws<StripeException>(() =>
                new StripeAccountService(Cache.ApiKey).Create(
                    new StripeAccountCreateOptions
                    {
                    }
                )
            );

            exception.StripeError.StripeResponse.Should().NotBeNull();
        }
    }
}
