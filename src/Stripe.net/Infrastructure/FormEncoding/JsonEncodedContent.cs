namespace Stripe.Infrastructure.FormEncoding
{
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using Newtonsoft.Json;

    /// <summary>
    /// A container for name/value tuples encoded using <c>application/json</c>
    /// MIME type.
    /// </summary>
    internal class JsonEncodedContent : ByteArrayContent
    {
        private static readonly JsonSerializerSettings SerializerSettings = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };

        /// <summary>
        /// Initializes a new instance of the <see cref="JsonEncodedContent"/> class.
        /// </summary>
        /// <param name="options">The options object.</param>
        public JsonEncodedContent(BaseOptions options)
            : base(CreateContentByteArray(options))
        {
            this.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            this.Headers.ContentType.CharSet = "utf-8";
        }

        private static byte[] CreateContentByteArray(
            BaseOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(options, Formatting.None, SerializerSettings));
        }
    }
}