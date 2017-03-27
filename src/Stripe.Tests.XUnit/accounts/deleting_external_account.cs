using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class deleting_external_account : IClassFixture<account_fixture>
    {
        private readonly account_fixture fixture;

        public deleting_external_account(account_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void should_throw_exception_its_default_account()
        {
            var exception = Assert.Throws<StripeException>(() =>
                new StripeExternalAccountService(Cache.ApiKey).Delete(
                    fixture.Account.Id,
                    fixture.Account.ExternalAccounts.Data.First().Card.Id
                )
            );

            exception.Message.Should().Contain("You cannot delete the default external account for your default currency.");
        }
    }
}
