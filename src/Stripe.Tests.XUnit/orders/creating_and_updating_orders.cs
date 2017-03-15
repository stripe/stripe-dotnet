using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_orders : IClassFixture<order_fixture>
    {
        private readonly order_fixture fixture;

        public creating_and_updating_orders(order_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Order.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_amount()
        {
            fixture.Order.Amount.Should().Be(fixture.OrderCreateOptions.StripeOrderItems.Sum(x => x.Amount));
        }

        [Fact]
        public void created_has_right_email()
        {
            fixture.Order.Email.Should().Be(fixture.OrderCreateOptions.Email);
        }

        [Fact]
        public void created_has_right_metadata()
        {
            fixture.Order.Metadata.ShouldBeEquivalentTo(fixture.OrderCreateOptions.Metadata);
        }

        [Fact]
        public void created_has_right_shipping_address()
        {
            fixture.Order.Shipping.Address.CityOrTown.Should().Be(fixture.OrderCreateOptions.Shipping.Address.CityOrTown);
            fixture.Order.Shipping.Address.Country.Should().Be(fixture.OrderCreateOptions.Shipping.Address.Country);
            fixture.Order.Shipping.Address.Line1.Should().Be(fixture.OrderCreateOptions.Shipping.Address.Line1);
            fixture.Order.Shipping.Address.Line2.Should().Be(fixture.OrderCreateOptions.Shipping.Address.Line2);
            fixture.Order.Shipping.Address.PostalCode.Should().Be(fixture.OrderCreateOptions.Shipping.Address.PostalCode);
            fixture.Order.Shipping.Address.State.Should().Be(fixture.OrderCreateOptions.Shipping.Address.State);
        }
    }
}
