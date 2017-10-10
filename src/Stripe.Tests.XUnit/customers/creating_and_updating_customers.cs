using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_customers : IClassFixture<customers_fixture>
    {
        private readonly customers_fixture fixture;

        public creating_and_updating_customers(customers_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_has_the_right_email()
        {
            fixture.CustomerWithShipping.Email.Should().Be(fixture.CustomerCreateOptionsWithShipping.Email);
        }

        [Fact]
        public void shipping_is_not_null()
        {
            fixture.CustomerWithShipping.Shipping.Should().NotBeNull();
        }

        [Fact]
        public void shipping_has_the_right_name()
        {
            fixture.CustomerWithShipping.Shipping.Name.Should().Be(fixture.CustomerCreateOptionsWithShipping.Shipping.Name);
        }

        [Fact]
        public void shipping_address_is_not_null()
        {
            fixture.CustomerWithShipping.Shipping.Address.Should().NotBeNull();
        }

        [Fact]
        public void shipping_has_the_right_line1()
        {
            fixture.CustomerWithShipping.Shipping.Address.Line1.Should().Be(fixture.CustomerCreateOptionsWithShipping.Shipping.Line1);
        }

        [Fact]
        public void shipping_has_the_right_line2()
        {
            fixture.CustomerWithShipping.Shipping.Address.Line2.Should().Be(fixture.CustomerCreateOptionsWithShipping.Shipping.Line2);
        }

        [Fact]
        public void shipping_has_the_right_country()
        {
            fixture.CustomerWithShipping.Shipping.Address.Country.Should().Be(fixture.CustomerCreateOptionsWithShipping.Shipping.Country);
        }

        [Fact]
        public void shipping_has_the_right_state()
        {
            fixture.CustomerWithShipping.Shipping.Address.State.Should().Be(fixture.CustomerCreateOptionsWithShipping.Shipping.State);
        }

        [Fact]
        public void updated_has_the_right_email()
        {
            fixture.UpdatedCustomerWithShipping.Email.Should().Be(fixture.CustomerUpdateOptionsWithShipping.Email);
        }

        [Fact]
        public void updated_shipping_has_the_right_phone()
        {
            fixture.UpdatedCustomerWithShipping.Shipping.Phone.Should().Be(fixture.CustomerUpdateOptionsWithShipping.Shipping.Phone);
        }
    }
}
