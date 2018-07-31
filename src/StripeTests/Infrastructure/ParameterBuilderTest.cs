namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class ParameterBuilderTest : BaseStripeTest
    {
        private TestService service;

        public ParameterBuilderTest()
        {
            this.service = new TestService();
        }

        [Fact]
        public void SetsUrl()
        {
            Assert.NotNull(this.service);

            var testObject = new TestOptions();
            var url = this.service.ApplyAllParameters(null, "base_url", false);
            Assert.Equal("base_url", url);
        }

        [Fact]
        public void EncodesParameters()
        {
            Assert.NotNull(this.service);

            var testObject = new TestOptions();
            var url = this.service.ApplyAllParameters(testObject, string.Empty, false);
            Assert.Equal("?differentname=Foo&stringcontainingtext=Foo&number=42&metadata[A]=Value-A&metadata[B]=Value-B&dateequals=946702800&datelessthan[lt]=946702800&datecomplex[lt]=978307200&datecomplex[gt]=946702800", url);
            Assert.DoesNotContain("StringWithoutAttribute=", url);
            Assert.DoesNotContain("stringcontainingnull=", url);
            Assert.DoesNotContain("nullnumber=", url);
        }

        [Fact]
        public void ExpandServiceResource()
        {
            Assert.NotNull(this.service);

            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(new StripeBaseOptions(), string.Empty, false);
            Assert.Equal("?expand[]=simple&expand[]=multi_word_property", url);
        }

        [Fact]
        public void ExpandServiceList()
        {
            Assert.NotNull(this.service);

            this.service.ExpandSimple = true;
            this.service.ExpandMultiWordProperty = true;

            var url = this.service.ApplyAllParameters(new StripeBaseOptions(), string.Empty, true);
            Assert.Equal("?expand[]=data.simple&expand[]=data.multi_word_property", url);
        }

        [Fact]
        public void ExpandOptions()
        {
            var obj = new StripeBaseOptions();
            obj.AddExpand("example1.subexample1");
            obj.AddExpand("example2");
            obj.AddExpand("example3.subexample3");

            var url = this.service.ApplyAllParameters(obj, string.Empty, false);
            Assert.Equal("?expand[]=example1.subexample1&expand[]=example2&expand[]=example3.subexample3", url);
        }
    }
}
