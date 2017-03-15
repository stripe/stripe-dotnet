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

        //[Fact]
        //public void created_has_right_images()
        //{
        //    fixture.Product.Images.Should().BeEquivalentTo(fixture.ProductCreateOptions.Images);
        //}

        //[Fact]
        //public void created_has_right_url()
        //{
        //    fixture.Product.Url.Should().Be(fixture.ProductCreateOptions.Url);
        //}



        //[Fact]
        //public void updated_is_not_null()
        //{
        //    fixture.Product.Should().NotBeNull();
        //}

        //[Fact]
        //public void updated_has_right_shippable()
        //{
        //    fixture.ProductUpdated.Shippable.Should().Be(fixture.ProductUpdateOptions.Shippable.Value);
        //}

        //[Fact]
        //public void updated_has_right_package_dimensions()
        //{
        //    fixture.ProductUpdated.PackageDimensions.Width.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Width);
        //    fixture.ProductUpdated.PackageDimensions.Height.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Height);
        //    fixture.ProductUpdated.PackageDimensions.Length.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Length);
        //    fixture.ProductUpdated.PackageDimensions.Weight.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Weight);
        //}

        //[Fact]
        //public void updated_has_right_attributes()
        //{
        //    fixture.ProductUpdated.Attributes.Should().BeEquivalentTo(fixture.ProductUpdateOptions.Attributes);
        //}

        //[Fact]
        //public void updated_has_right_images()
        //{
        //    fixture.ProductUpdated.Images.Should().BeEquivalentTo(fixture.ProductUpdateOptions.Images);
        //}

        //[Fact]
        //public void updated_has_right_url()
        //{
        //    fixture.ProductUpdated.Url.Should().Be(fixture.ProductUpdateOptions.Url);
        //}

        //[Fact]
        //public void updated_has_right_metadata()
        //{
        //    //Metadata is additive unless you post an empty value for an existing key
        //    var expectedMetadata = new Dictionary<string, string>();
        //    fixture.ProductCreateOptions.Metadata.ToList().ForEach(x => expectedMetadata.Add(x.Key, x.Value));
        //    fixture.ProductUpdateOptions.Metadata.ToList().ForEach(x => expectedMetadata.Add(x.Key, x.Value));

        //    fixture.ProductUpdated.Metadata.ShouldBeEquivalentTo(expectedMetadata);
        //}
    }
}
