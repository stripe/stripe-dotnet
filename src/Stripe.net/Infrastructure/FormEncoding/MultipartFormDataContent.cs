namespace Stripe.Infrastructure.FormEncoding
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;

    /// <summary>
    /// A container for content encoded using <c>multipart/form-data</c> MIME type.
    /// </summary>
    internal class MultipartFormDataContent : System.Net.Http.MultipartFormDataContent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartFormDataContent"/> class.
        /// </summary>
        /// <param name="nameValueCollection">The collection of name/value tuples to encode.</param>
        public MultipartFormDataContent(IEnumerable<KeyValuePair<string, object>> nameValueCollection)
            : this(nameValueCollection, Guid.NewGuid().ToString())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartFormDataContent"/> class.
        /// </summary>
        /// <param name="nameValueCollection">The collection of name/value tuples to encode.</param>
        /// <param name="boundary">The boundary string for the multipart form data content.</param>
        public MultipartFormDataContent(
            IEnumerable<KeyValuePair<string, object>> nameValueCollection,
            string boundary)
            : base(boundary)
        {
            if (nameValueCollection == null)
            {
                throw new ArgumentNullException(nameof(nameValueCollection));
            }

            this.ProcessParameters(nameValueCollection);
        }

        private static StringContent CreateStringContent(string value)
            => new StringContent(value, System.Text.Encoding.UTF8);

        private static StreamContent CreateStreamContent(Stream value, string name)
        {
            var fileName = "blob";
            var extension = string.Empty;

#if NET45 || NETSTANDARD2_0
            FileStream fileStream = value as FileStream;
            if ((fileStream != null) && (!string.IsNullOrEmpty(fileStream.Name)))
            {
                fileName = fileStream.Name;
                extension = Path.GetExtension(fileName);
            }
#endif

            var content = new StreamContent(value);
            content.Headers.ContentDisposition = new ContentDispositionHeaderValue("form-data")
            {
                Name = name,
                FileName = fileName,
                FileNameStar = fileName,
            };
            content.Headers.ContentType = new MediaTypeHeaderValue(MimeTypes.GetMimeType(extension));
            return content;
        }

        private void ProcessParameters(IEnumerable<KeyValuePair<string, object>> nameValueCollection)
        {
            foreach (var kvp in nameValueCollection)
            {
                switch (kvp.Value)
                {
                    case string s:
                        this.Add(CreateStringContent(s), kvp.Key);
                        break;

                    case Stream s:
                        this.Add(CreateStreamContent(s, kvp.Key));
                        break;

                    default:
                        var message =
                            "Unexpected type in collection. Expected System.String or " +
                            $"System.IO.Stream, got {kvp.GetType().FullName}.";
                        throw new ArgumentException(message, nameof(nameValueCollection));
                }
            }
        }
    }
}
