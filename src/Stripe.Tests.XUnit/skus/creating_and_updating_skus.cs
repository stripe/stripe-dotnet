using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_skus : IClassFixture<skus_fixture>
    {
        private readonly skus_fixture fixture;

        public creating_and_updating_skus(skus_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Sku.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_id()
        {
            fixture.Sku.Id.Should().Be(fixture.SkuCreateOptions.Id);
        }

        [Fact]
        public void created_has_right_attributes()
        {
            fixture.Sku.Attributes.Should().Equal(fixture.SkuCreateOptions.Attributes);
        }

        [Fact]
        public void created_has_right_inventory()
        {
            fixture.Sku.Inventory.Quantity.Should().Be(fixture.SkuCreateOptions.Inventory.Quantity);
            fixture.Sku.Inventory.Type.Should().Be(fixture.SkuCreateOptions.Inventory.Type);
        }

        [Fact]
        public void created_has_right_package_dimensions()
        {
            fixture.Sku.PackageDimensions.Height.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Height);
            fixture.Sku.PackageDimensions.Length.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Length);
            fixture.Sku.PackageDimensions.Weight.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Weight);
            fixture.Sku.PackageDimensions.Width.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Width);
        }

        [Fact]
        public void retrieved_has_the_correct_id()
        {
            fixture.SkuRetrieved.Id.Should().Be(fixture.Sku.Id);
        }

        [Fact]
        public void updated_has_the_right_price()
        {
            fixture.SkuUpdated.Price.Should().Be(fixture.SkuUpdateOptions.Price);
        }
    }
}
