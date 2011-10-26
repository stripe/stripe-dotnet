using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace Stripe
{
    internal static class Requestor
    {
        public static string GetString(string url)
        {
            var wr = GetWebRequest(url, "GET");

            return ExecuteWebRequest(wr);
        }

        public static string PostString(string url)
        {
            var wr = GetWebRequest(url, "POST");

            return ExecuteWebRequest(wr);
        }

        public static string Delete(string url)
        {
            var wr = GetWebRequest(url, "DELETE");

            return ExecuteWebRequest(wr);
        }

        private static WebRequest GetWebRequest(string url, string method)
        {
            var request = (WebRequest) WebRequest.Create(url);
            request.Method = method;
            request.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["StripeApiKey"], string.Empty);
            request.ContentType = "application/x-www-form-urlencoded";

            if (request is HttpWebRequest)
                ((HttpWebRequest) request).UserAgent = "Stripe.net (https://github.com/jaymedavis/stripe.net)";

            return request;
        }

        private static string ExecuteWebRequest(WebRequest webRequest)
        {
            try
            {
                using(var response = webRequest.GetResponse())
                {
                    return ReadStream(response.GetResponseStream());
                }
            }
            catch(WebException webException)
            {
                if (webException.Response != null)
                {
                    var statusCode = ((HttpWebResponse) webException.Response).StatusCode;
                    var stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));

                    throw new StripeException(statusCode, stripeError, stripeError.Message);
                }

                throw;
            }
        }

        private static string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}