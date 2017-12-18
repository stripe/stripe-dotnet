using System;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class charging_from_another_account : IClassFixture<connect_fixture>
    {
        private readonly connect_fixture fixture;

        public charging_from_another_account(connect_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void it_should_have_connected_app_on_charge()
        {
            this.fixture.Charge.ApplicationId.Should().StartWith("ca_");
            this.fixture.Charge.Application.Should().NotBeNull();
        }

        [Fact]
        public void it_should_have_connected_app_on_app_fee()
        {
            this.fixture.ApplicationFee.ApplicationId.Should().StartWith("ca_");
            this.fixture.ApplicationFee.Application.Should().NotBeNull();
        }
    }
}
