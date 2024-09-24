namespace StripeTests
{
    using Stripe;
    using Stripe.Infrastructure;
    using Stripe.Infrastructure.FormEncoding;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class EmptyableConverterTest : BaseStripeTest
    {
        [Fact]
        public async void SerializeEmpty()
        {
            var obj = new TestOptions()
            {
                EmptyEmptyStringable = true,
            };

            var expected = "{\"empty_stringable\":null}";
            var result = await ContentEncoder.CreateHttpContent(obj, ApiMode.V2).ReadAsStringAsync();
            Assert.Equal(expected, result);
        }

        [Fact]
        public async void SerializeMissing()
        {
            var obj = new TestOptions()
            {
            };

            var expected = "{}";
            var result = await ContentEncoder.CreateHttpContent(obj, ApiMode.V2).ReadAsStringAsync();
            Assert.Equal(expected, result);
        }

        [Fact]
        public async void SerializeValue()
        {
            var obj = new TestOptions()
            {
                EmptyStringable = new TestOptions.Nested()
                {
                    Bool = true,
                },
            };

            var expected = "{\"empty_stringable\":{\"bool\":true}}";
            var result = await ContentEncoder.CreateHttpContent(obj, ApiMode.V2).ReadAsStringAsync();
            Assert.Equal(expected, result);
        }

        [Fact]
        public async void SerializeEmptied()
        {
            var obj = new TestOptions()
            {
            };
            obj.EmptyStringable = new TestOptions.Nested()
            {
                Bool = true,
            };

            obj.EmptyEmptyStringable = true;

            var expected = "{\"empty_stringable\":null}";
            var result = await ContentEncoder.CreateHttpContent(obj, ApiMode.V2).ReadAsStringAsync();
            Assert.Equal(expected, result);
        }

        [Fact]
        public async void SerializeUnemptied()
        {
            var obj = new TestOptions()
            {
            };

            obj.EmptyEmptyStringable = true;
            obj.EmptyStringable = new TestOptions.Nested()
            {
                Bool = true,
            };

            var expected = "{\"empty_stringable\":{\"bool\":true}}";
            var result = await ContentEncoder.CreateHttpContent(obj, ApiMode.V2).ReadAsStringAsync();
            Assert.Equal(expected, result);
        }
    }
}
