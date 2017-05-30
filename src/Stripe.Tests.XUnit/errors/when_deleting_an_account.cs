using System;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class when_deleting_an_account
    {
        private static string _stripeAccountId;
        private static StripeAccountService _stripeAccountService;
        private static StripeAccountCreateOptions _stripeAccountCreateOptions;

        public when_deleting_an_account()
        {
            _stripeAccountService = new StripeAccountService(Cache.ApiKey);
            _stripeAccountCreateOptions = new StripeAccountCreateOptions()
            {
                Email = "joe@" + Guid.NewGuid() + ".com",
                Type = StripeAccountType.Custom
            };
            _stripeAccountId = _stripeAccountService.Create(_stripeAccountCreateOptions).Id;

            _stripeAccountService.Delete(_stripeAccountId);
        }

        [Fact]
        public void it_should_throw_exception_when_getting()
        {
            var exception = Assert.Throws<StripeException>(() =>
                    _stripeAccountService.Get(_stripeAccountId)
            );

            exception.Message.Should().Contain("or that account does not exist");
        }
    }
}
