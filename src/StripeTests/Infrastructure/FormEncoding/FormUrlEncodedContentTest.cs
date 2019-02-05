namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class FormUrlEncodedContentTest : BaseStripeTest
    {
        [Fact]
        public void Ctor_NullSource_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new FormUrlEncodedContent(null));
        }

        [Fact]
        public async Task Ctor_EmptySource_Succeed()
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>());
            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(0, stream.Length);
        }

        [Fact]
        public void Ctor_EmptySource_CorrectMediaTypeAndCharset()
        {
            var content = new FormUrlEncodedContent(new Dictionary<string, string>());
            Assert.Equal("application/x-www-form-urlencoded", content.Headers.ContentType.MediaType);
            Assert.Equal("utf-8", content.Headers.ContentType.CharSet);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);
        }

        [Fact]
        public async Task Ctor_OneEntry_SeparatedByEquals()
        {
            var data = new Dictionary<string, string> { { "key", "value" } };
            var content = new FormUrlEncodedContent(data);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(9, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("key=value", result);
        }

        [Fact]
        public async Task Ctor_OneUnicodeEntry_Encoded()
        {
            var data = new Dictionary<string, string> { { "key", "valueク" } };
            var content = new FormUrlEncodedContent(data);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(18, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("key=value%E3%82%AF", result);
        }

        [Fact]
        public async Task Ctor_TwoEntries_SeparatedByAnd()
        {
            var data = new Dictionary<string, string>
            {
                { "key1", "value1" },
                { "key2", "value2" },
            };
            var content = new FormUrlEncodedContent(data);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(23, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("key1=value1&key2=value2", result);
        }

        [Fact]
        public async Task Ctor_WithSpaces_EncodedAsPlus()
        {
            var data = new Dictionary<string, string>
            {
                { "key 1", "val%20ue 1" },
                { "key 2", "val%ue 2" },
            };
            var content = new FormUrlEncodedContent(data);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(35, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("key+1=val%2520ue+1&key+2=val%25ue+2", result);
        }

        [Fact]
        public async Task Ctor_WithSquareBrackets_Unencoded()
        {
            var data = new Dictionary<string, string> { { "key[subkey]", "[#value]" } };
            var content = new FormUrlEncodedContent(data);

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(22, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("key[subkey]=[%23value]", result);
        }
    }
}
