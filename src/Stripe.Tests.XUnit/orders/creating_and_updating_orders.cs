using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_orders : IClassFixture<orders_fixture>
    {
        private readonly orders_fixture fixture;

        public creating_and_updating_orders(orders_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Order.Should().NotBeNull();
        }

        [Fact]
        public void created_has_the_right_shipping_name()
        {
            fixture.Order.Shipping.Name.Should().Be(fixture.OrderCreateOptions.Shipping.Name);
        }

        [Fact]
        public void created_has_the_right_shipping_line1()
        {
            fixture.Order.Shipping.Address.Line1.Should().Be(fixture.OrderCreateOptions.Shipping.Line1);
        }

        [Fact]
        public void updated_is_not_null()
        {
            fixture.OrderUpdated.Should().NotBeNull();
        }

        [Fact]
        public void retrieved_is_not_null()
        {
            fixture.OrderRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void paid_is_not_null()
        {
            fixture.OrderPaid.Should().NotBeNull();
        }
    }
}
