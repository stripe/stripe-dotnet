namespace Stripe.Infrastructure.FormEncoding
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    internal static class MimeTypes
    {
        // Dictionary mapping file extensions to MIME types. Stripe's file upload API accepts
        // only a limited set of file types that are listed below. It's not hugely important if
        // a type is missing or incorrect, as the server doesn't trust the Content-Type header
        // and checks the actual file contents anyway.
        private static readonly IDictionary<string, string> MimeTypeMap
            = new Dictionary<string, string>
        {
            { ".csv", "text/csv" },
            { ".docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
            { ".gif", "image/gif" },
            { ".jpeg", "image/jpeg" },
            { ".jpg", "image/jpeg" },
            { ".pdf", "application/pdf" },
            { ".png", "image/png" },
            { ".xls", "application/vnd.ms-excel" },
            { ".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet" },
        }.ToImmutableDictionary();

        /// <summary>Gets the content type for a given file extension.</summary>
        /// <param name="extension">The file extension.</param>
        /// <returns>
        /// The content type, or <c>application/octet-stream</c> if the file extension is unknown.
        /// </returns>
        public static string GetMimeType(string extension)
        {
            if (extension == null)
            {
                throw new ArgumentNullException(nameof(extension));
            }

            if (!extension.StartsWith("."))
            {
                extension = "." + extension;
            }

            string mime;

            return MimeTypeMap.TryGetValue(extension, out mime) ? mime : "application/octet-stream";
        }
    }
}
