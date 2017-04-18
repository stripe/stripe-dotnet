using FluentAssertions;
using Xunit;

namespace Stripe.Tests.Xunit
{
    public class creating_and_updating_products : IClassFixture<products_fixture>
    {
        private readonly products_fixture fixture;

        public creating_and_updating_products(products_fixture fixture)
        {
            this.fixture = fixture;
        }

        [Fact]
        public void created_is_not_null()
        {
            fixture.Product.Should().NotBeNull();
        }

        [Fact]
        public void created_has_right_name()
        {
            fixture.Product.Name.Should().Be(fixture.ProductCreateOptions.Name);
        }

        [Fact]
        public void get_is_not_null()
        {
            fixture.ProductRetrieved.Should().NotBeNull();
        }

        [Fact]
        public void updated_is_not_null()
        {
            fixture.ProductUpdated.Should().NotBeNull();
        }

        [Fact]
        public void updated_has_right_name()
        {
            fixture.ProductUpdated.Name.Should().Be(fixture.ProductUpdateOptions.Name);
        }

        [Fact]
        public void list_is_not_null()
        {
            fixture.ProductList.Should().NotBeNull();
        }
    }
}
