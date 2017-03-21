using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_products : IClassFixture<product_fixture>
    {
        private readonly product_fixture fixture;

        public creating_and_updating_products(product_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.ProductCreated.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_shippable()
        {
            fixture.ProductCreated.Shippable.Should().Be(fixture.ProductCreateOptions.Shippable.Value);
        }

        [Fact]
        public void created_has_right_package_dimensions()
        {
            fixture.ProductCreated.PackageDimensions.Width.Should().Be(fixture.ProductCreateOptions.PackageDimensions.Width);
            fixture.ProductCreated.PackageDimensions.Height.Should().Be(fixture.ProductCreateOptions.PackageDimensions.Height);
            fixture.ProductCreated.PackageDimensions.Length.Should().Be(fixture.ProductCreateOptions.PackageDimensions.Length);
            fixture.ProductCreated.PackageDimensions.Weight.Should().Be(fixture.ProductCreateOptions.PackageDimensions.Weight);
        }

        [Fact]
        public void created_has_right_attributes()
        {
            fixture.ProductCreated.Attributes.Should().BeEquivalentTo(fixture.ProductCreateOptions.Attributes);
        }

        [Fact]
        public void created_has_right_images()
        {
            fixture.ProductCreated.Images.Should().BeEquivalentTo(fixture.ProductCreateOptions.Images);
        }

        [Fact]
        public void created_has_right_url()
        {
            fixture.ProductCreated.Url.Should().Be(fixture.ProductCreateOptions.Url);
        }

        [Fact]
        public void created_has_right_metadata()
        {
            fixture.ProductCreated.Metadata.ShouldBeEquivalentTo(fixture.ProductCreateOptions.Metadata);
        }

        [Fact]
        public void updated_is_not_null()
        {
            fixture.ProductCreated.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_right_shippable()
        {
            fixture.ProductUpdated.Shippable.Should().Be(fixture.ProductUpdateOptions.Shippable.Value);
        }

        [Fact]
        public void updated_has_right_package_dimensions()
        {
            fixture.ProductUpdated.PackageDimensions.Width.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Width);
            fixture.ProductUpdated.PackageDimensions.Height.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Height);
            fixture.ProductUpdated.PackageDimensions.Length.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Length);
            fixture.ProductUpdated.PackageDimensions.Weight.Should().Be(fixture.ProductUpdateOptions.PackageDimensions.Weight);
        }

        [Fact]
        public void updated_has_right_attributes()
        {
            fixture.ProductUpdated.Attributes.Should().BeEquivalentTo(fixture.ProductUpdateOptions.Attributes);
        }

        [Fact]
        public void updated_has_right_images()
        {
            fixture.ProductUpdated.Images.Should().BeEquivalentTo(fixture.ProductUpdateOptions.Images);
        }

        [Fact]
        public void updated_has_right_url()
        {
            fixture.ProductUpdated.Url.Should().Be(fixture.ProductUpdateOptions.Url);
        }

        [Fact]
        public void updated_has_right_metadata()
        {
            //Metadata is additive unless you post an empty value for an existing key
            var expectedMetadata = new Dictionary<string, string>();
            fixture.ProductCreateOptions.Metadata.ToList().ForEach(x => expectedMetadata.Add(x.Key, x.Value));
            fixture.ProductUpdateOptions.Metadata.ToList().ForEach(x => expectedMetadata.Add(x.Key, x.Value));

            fixture.ProductUpdated.Metadata.ShouldBeEquivalentTo(expectedMetadata);
        }
    }
}
