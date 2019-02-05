namespace StripeTests
{
    using System;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class MimeTypesTest : BaseStripeTest
    {
        [Fact]
        public void GetMimeType_Null_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => MimeTypes.GetMimeType(null));
        }

        [Fact]
        public void GetMimeType_KnownExtension_Success()
        {
            Assert.Equal("application/pdf", MimeTypes.GetMimeType(".pdf"));
        }

        [Fact]
        public void GetMimeType_KnownExtensionWithoutLeadingDot_Success()
        {
            Assert.Equal("application/pdf", MimeTypes.GetMimeType("pdf"));
        }

        [Fact]
        public void GetMimeType_UnknownExtension_Success()
        {
            Assert.Equal("application/octet-stream", MimeTypes.GetMimeType("foo"));
        }
    }
}
