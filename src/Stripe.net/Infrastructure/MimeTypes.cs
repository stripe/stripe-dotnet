namespace Stripe.Infrastructure
{
    using System.IO;

    internal static class MimeTypes
    {
        public static string GetMimeType(string fileName)
        {
            switch (Path.GetExtension(fileName.ToLowerInvariant()))
            {
                case ".jpeg":
                case ".jpg":
                    return "image/jpeg";

                case ".pdf":
                    return "application/pdf";

                case ".png":
                    return "image/png";

                default:
                    return "application/octet-stream";
            }
        }
    }
}
