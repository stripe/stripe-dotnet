using System.IO;

namespace Stripe.Infrastructure
{
    internal static class MimeTypes
    {
        public static string GetMimeType(string fileName)
        {
            switch (Path.GetExtension(fileName.ToLower()))
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