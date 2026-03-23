namespace StripeTests
{
    using System.Collections.Generic;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using StripeTests.Infrastructure.TestData;
    using Xunit;

    public class SetTrackingTest : BaseStripeTest
    {
        // v1 form encoding: set-tracked null sends field= (empty string to clear)
        [Fact]
        public void V1FormEncoding_SetToNull_SendsEmptyString()
        {
            var options = new TestOptions();
            options.EmptyableString = null;

            var result = ContentEncoder.CreateQueryString(options);
            Assert.Equal("emptyable_string=", result);
        }

        // v1 form encoding: unset property is omitted entirely
        [Fact]
        public void V1FormEncoding_NeverSet_Omitted()
        {
            var options = new TestOptions();

            var result = ContentEncoder.CreateQueryString(options);
            Assert.Equal(string.Empty, result);
        }

        // v1 form encoding: set to a value sends normally
        [Fact]
        public void V1FormEncoding_SetToValue_SendsValue()
        {
            var options = new TestOptions();
            options.EmptyableString = "hello";

            var result = ContentEncoder.CreateQueryString(options);
            Assert.Equal("emptyable_string=hello", result);
        }

        // v1 form encoding: set-tracked null nested object sends field= (empty string)
        [Fact]
        public void V1FormEncoding_SetNestedToNull_SendsEmptyString()
        {
            var options = new TestOptions();
            options.EmptyableNested = null;

            var result = ContentEncoder.CreateQueryString(options);
            Assert.Equal("emptyable_nested=", result);
        }

        // v1 form encoding: non-tracked string property with null is still omitted
        [Fact]
        public void V1FormEncoding_NonTrackedNull_Omitted()
        {
            var options = new TestOptions();
            options.String = null;

            var result = ContentEncoder.CreateQueryString(options);
            Assert.Equal(string.Empty, result);
        }

        // v2 JSON encoding: set-tracked null sends "field": null
        [Fact]
        public async void V2JsonEncoding_SetToNull_SendsNull()
        {
            var options = new TestOptions();
            options.EmptyableString = null;

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Equal("{\"emptyable_string\":null}", result);
        }

        // v2 JSON encoding: unset property is omitted
        [Fact]
        public async void V2JsonEncoding_NeverSet_Omitted()
        {
            var options = new TestOptions();

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Equal("{}", result);
        }

        // v2 JSON encoding: set to a value sends normally
        [Fact]
        public async void V2JsonEncoding_SetToValue_SendsValue()
        {
            var options = new TestOptions();
            options.EmptyableString = "hello";

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Equal("{\"emptyable_string\":\"hello\"}", result);
        }

        // v2 JSON encoding: null-preserving dictionary sends {"key": null}
        [Fact]
        public async void V2JsonEncoding_MetadataDictWithNull_PreservesNull()
        {
            var options = new TestOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "keep", "value" },
                    { "delete", null },
                },
            };

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Contains("\"keep\":\"value\"", result);
            Assert.Contains("\"delete\":null", result);
        }

        // v2 JSON encoding: null-preserving dictionary with all non-null values works normally
        [Fact]
        public async void V2JsonEncoding_MetadataDictAllValues_Normal()
        {
            var options = new TestOptions
            {
                Metadata = new Dictionary<string, string>
                {
                    { "key1", "val1" },
                    { "key2", "val2" },
                },
            };

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Contains("\"key1\":\"val1\"", result);
            Assert.Contains("\"key2\":\"val2\"", result);
        }

        // v2 JSON encoding: set-tracked null nested object sends null
        [Fact]
        public async void V2JsonEncoding_SetNestedToNull_SendsNull()
        {
            var options = new TestOptions();
            options.EmptyableNested = null;

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Equal("{\"emptyable_nested\":null}", result);
        }

        // Set then unset via null should still track
        [Fact]
        public async void V2JsonEncoding_SetValueThenNull_SendsNull()
        {
            var options = new TestOptions();
            options.EmptyableString = "hello";
            options.EmptyableString = null;

            var result = await ContentEncoder.CreateHttpContent(options, ApiMode.V2)
                .ReadAsStringAsync();
            Assert.Equal("{\"emptyable_string\":null}", result);
        }
    }
}
