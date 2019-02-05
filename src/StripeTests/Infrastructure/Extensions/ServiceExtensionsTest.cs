namespace StripeTests
{
    using Stripe.Infrastructure.Extensions;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class ServiceExtensionsTest : BaseStripeTest
    {
        private readonly TestService service = new TestService();

        [Fact]
        public void Expansions()
        {
            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var expansions = this.service.Expansions(false);
            Assert.NotNull(expansions);
            Assert.Collection(
                expansions,
                i1 => Assert.Equal("simple", i1),
                i2 => Assert.Equal("multi_word_property", i2));
        }

        [Fact]
        public void ExpansionsForListMethod()
        {
            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var expansions = this.service.Expansions(true);
            Assert.NotNull(expansions);
            Assert.Collection(
                expansions,
                i1 => Assert.Equal("data.simple", i1),
                i2 => Assert.Equal("data.multi_word_property", i2));
        }
    }
}
