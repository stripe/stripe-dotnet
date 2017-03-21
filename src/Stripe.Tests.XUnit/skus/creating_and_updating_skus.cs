using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_skus : IClassFixture<sku_fixture>
    {
        private readonly sku_fixture fixture;

        public creating_and_updating_skus(sku_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.SkuCreated.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_price()
        {
            fixture.SkuCreated.Price.Should().Be(fixture.SkuCreateOptions.Price);
        }

        [Fact]
        public void created_has_right_product_id()
        {
            fixture.SkuCreated.ProductId.Should().Be(fixture.SkuCreateOptions.ProductId);
        }

        [Fact]
        public void created_has_right_attributes()
        {
            fixture.SkuCreated.Attributes.ShouldBeEquivalentTo(fixture.SkuCreateOptions.Attributes);
        }

        [Fact]
        public void created_has_right_active()
        {
            fixture.SkuCreated.Active.Should().Be(fixture.SkuCreateOptions.Active.Value);
        }

        [Fact]
        public void created_has_right_image()
        {
            fixture.SkuCreated.Image.Should().Be(fixture.SkuCreateOptions.Image);
        }

        [Fact]
        public void created_has_right_package_dimensions()
        {
            fixture.SkuCreated.PackageDimensions.Width.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Width);
            fixture.SkuCreated.PackageDimensions.Height.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Height);
            fixture.SkuCreated.PackageDimensions.Length.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Length);
            fixture.SkuCreated.PackageDimensions.Weight.Should().Be(fixture.SkuCreateOptions.PackageDimensions.Weight);
        }

        [Fact]
        public void created_has_right_metadata()
        {
            fixture.SkuCreated.Metadata.ShouldBeEquivalentTo(fixture.SkuCreateOptions.Metadata);
        }







        [Fact]
        public void updated_is_not_null()
        {
            fixture.SkuUpdated.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_right_price()
        {
            fixture.SkuUpdated.Price.Should().Be(fixture.SkuUpdateOptions.Price.Value);
        }

        [Fact]
        public void updated_has_right_product_id()
        {
            fixture.SkuUpdated.ProductId.Should().Be(fixture.SkuUpdateOptions.ProductId);
        }

        [Fact]
        public void updated_has_right_attributes()
        {
            fixture.SkuUpdated.Attributes.ShouldBeEquivalentTo(fixture.SkuUpdateOptions.Attributes);
        }

        [Fact]
        public void updated_has_right_active()
        {
            fixture.SkuUpdated.Active.Should().Be(fixture.SkuUpdateOptions.Active.Value);
        }

        [Fact]
        public void updated_has_right_image()
        {
            fixture.SkuUpdated.Image.Should().Be(fixture.SkuUpdateOptions.Image);
        }

        [Fact]
        public void updated_has_right_package_dimensions()
        {
            fixture.SkuUpdated.PackageDimensions.Width.Should().Be(fixture.SkuUpdateOptions.PackageDimensions.Width);
            fixture.SkuUpdated.PackageDimensions.Height.Should().Be(fixture.SkuUpdateOptions.PackageDimensions.Height);
            fixture.SkuUpdated.PackageDimensions.Length.Should().Be(fixture.SkuUpdateOptions.PackageDimensions.Length);
            fixture.SkuUpdated.PackageDimensions.Weight.Should().Be(fixture.SkuUpdateOptions.PackageDimensions.Weight);
        }

        [Fact]
        public void updated_has_right_metadata()
        {
            //Metadata is additive unless you post an empty value for an existing key
            var expectedMetadata = new Dictionary<string, string>();
            fixture.SkuCreateOptions.Metadata.ToList().ForEach(x => expectedMetadata.Add(x.Key, x.Value));
            fixture.SkuUpdateOptions.Metadata.ToList().ForEach(x => expectedMetadata.Add(x.Key, x.Value));

            fixture.SkuUpdated.Metadata.ShouldBeEquivalentTo(expectedMetadata);
        }
    }
}
