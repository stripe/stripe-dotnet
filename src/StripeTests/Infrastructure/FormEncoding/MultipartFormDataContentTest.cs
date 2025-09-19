namespace StripeTests
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    using System.Threading.Tasks;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class MultipartFormDataContentTest : BaseStripeTest
    {
        [Fact]
        public void Ctor_NullSource_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MultipartFormDataContent(null));
        }

        [Fact]
        public void Ctor_EmptySource_CorrectMediaType()
        {
            var content = new MultipartFormDataContent(new Dictionary<string, object>());
            Assert.Equal("multipart/form-data", content.Headers.ContentType.MediaType);
            Assert.Equal(1, content.Headers.ContentType.Parameters.Count);
        }

        [Fact]
        public async Task Ctor_EmptySource_Success()
        {
            var source = new Dictionary<string, object>();
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(38, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal("--test-boundary\r\n\r\n--test-boundary--\r\n", result);
        }

        [Fact]
        public async Task Ctor_OneStringEntry_Success()
        {
            var source = new Dictionary<string, object> { { "key", "valueク" } };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(133, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\nContent-Type: text/plain; charset=utf-8\r\n"
                + "Content-Disposition: form-data; name=\"key\"\r\n\r\nvalueク\r\n--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_OneStreamEntry_Success()
        {
            var source = new Dictionary<string, object>
            {
                { "key", new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")) },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(174, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"key\"; filename=blob; filename*=utf-8''blob\r\n"
                + "Content-Type: application/octet-stream\r\n\r\nHello World!\r\n"
                + "--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_OneMultipartFileContentEntry_Success()
        {
            var source = new Dictionary<string, object>
            {
                { "key", new MultipartFileContent { Data = new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")) } },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(174, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"key\"; filename=blob; filename*=utf-8''blob\r\n"
                + "Content-Type: application/octet-stream\r\n\r\nHello World!\r\n"
                + "--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_OneMultipartFileContentWithNameEntry_Success()
        {
            var source = new Dictionary<string, object>
            {
                {
                    "key", new MultipartFileContent
                    {
                         Data = new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")),
                         Name = "file",
                    }
                },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(174, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"key\"; filename=file; filename*=utf-8''file\r\n"
                + "Content-Type: application/octet-stream\r\n\r\nHello World!\r\n"
                + "--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_OneMultipartFileContentWithNameAndExtEntry_Success()
        {
            var source = new Dictionary<string, object>
            {
                {
                    "key", new MultipartFileContent
                    {
                        Data = new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")),
                        Name = "file.csv",
                    }
                },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(166, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"key\"; filename=file.csv; filename*=utf-8''file.csv\r\n"
                + "Content-Type: text/csv\r\n\r\nHello World!\r\n"
                + "--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_OneMultipartFileContentWithNameAndTypeEntry_Success()
        {
            var source = new Dictionary<string, object>
            {
                {
                    "key", new MultipartFileContent
                    {
                        Data = new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")),
                        Name = "file",
                        Type = "application/json",
                    }
                },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(166, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"key\"; filename=file; filename*=utf-8''file\r\n"
                + "Content-Type: application/json\r\n\r\nHello World!\r\n"
                + "--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_OneMultipartFileContentWithNameAndExtAndTypeEntry_Success()
        {
            var source = new Dictionary<string, object>
            {
                {
                    "key", new MultipartFileContent
                    {
                        Data = new MemoryStream(Encoding.UTF8.GetBytes("Hello World!")),
                        Name = "file.json",
                        Type = "application/octet-stream",
                    }
                },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(184, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"key\"; filename=file.json; filename*=utf-8''file.json\r\n"
                + "Content-Type: application/octet-stream\r\n\r\nHello World!\r\n"
                + "--test-boundary--\r\n",
                result);
        }

        [Fact]
        public async Task Ctor_TwoEntries_Success()
        {
            var source = new Dictionary<string, object>
            {
                { "stream", new MemoryStream(Encoding.UTF8.GetBytes("Hello クWorld!")) },
                { "string", "String!ク" },
            };
            var content = new MultipartFormDataContent(source, "test-boundary");

            var stream = await content.ReadAsStreamAsync();
            Assert.Equal(299, stream.Length);
            var result = new StreamReader(stream).ReadToEnd();
            Assert.Equal(
                "--test-boundary\r\n"
                + "Content-Disposition: form-data; name=\"stream\"; filename=blob; filename*=utf-8''blob\r\n"
                + "Content-Type: application/octet-stream\r\n\r\nHello クWorld!\r\n"
                + "--test-boundary\r\nContent-Type: text/plain; charset=utf-8\r\n"
                + "Content-Disposition: form-data; name=\"string\"\r\n\r\nString!ク\r\n--test-boundary--\r\n",
                result);
        }

        [Fact]
        public void Ctor_OneNonStringNonStreamEntry_ThrowsArgumentException()
        {
            var source = new Dictionary<string, object> { { "key", 234 } };
            Assert.Throws<ArgumentException>(
                () => new MultipartFormDataContent(source, "test-boundary"));
        }
    }
}
