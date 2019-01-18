namespace StripeTests
{
    using Stripe.Infrastructure.Extensions;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class ServiceExtensionsTest : BaseStripeTest
    {
        private readonly TestService service = new TestService();

        [Fact]
        public void ExpandServiceResource()
        {
            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(null, string.Empty, false);
            Assert.Equal("?expand[0]=simple&expand[1]=multi_word_property", url);
        }

        [Fact]
        public void ExpandServiceList()
        {
            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(null, string.Empty, true);
            Assert.Equal("?expand[0]=data.simple&expand[1]=data.multi_word_property", url);
        }

        [Fact]
        public void SetsUrl()
        {
            var url = this.service.ApplyAllParameters(null, "base_url", false);
            Assert.Equal("base_url", url);
        }

        [Fact]
        public void ExpandViaServicePropertiesAndOptionsClass()
        {
            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var options = new TestOptions();
            options.AddExpand("foo");
            options.AddExpand("bar.baz");

            var url = this.service.ApplyAllParameters(options, string.Empty, false);
            Assert.Equal(
                "?expand[0]=simple&expand[1]=multi_word_property&expand[2]=foo&expand[3]=bar.baz",
                url);
        }
    }
}
