namespace Stripe
{
    using System.IO;

    /// <summary>
    /// Represents a File to be uploaded with FileService.Create.
    ///
    /// Name and Type are optional (see comments below).
    /// </summary>
    public class FileFileOptions
    {
        /// <summary>
        /// The file data to send.  If this is a FileStream, the SDK will infer
        /// the name and type from the file name and extension.  If this is not
        /// a FileStream set Name and Type to configure the file upload.
        /// </summary>
        public Stream Data { get; set; }

        /// <summary>
        /// The optional name to send with this file data.  Uses the file name if omitted
        /// and Data is a FileStream.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The optional mime type to use when sending file data.  Uses the type that
        /// matches the file extension from Name (or the file name from Data) if omitted.
        /// </summary>
        public string Type { get; set; }
    }
}
