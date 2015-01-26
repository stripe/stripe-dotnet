using System;
using System.IO;
using System.Net;
using System.Text;

#if NET40
using System.Threading.Tasks;
#endif

namespace Stripe
{
    internal static class Requestor
    {
        public static string GetString(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "GET", apiKey);

            return ExecuteWebRequest(wr);
        }

#if NET40
        public static Task<string> GetStringAsync(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "GET", apiKey);

            return ExecuteWebRequestAsync(wr);
        }
#endif

        public static string PostString(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey);

            return ExecuteWebRequest(wr);
        }

#if NET40
        public static Task<string> PostStringAsync(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey);

            return ExecuteWebRequestAsync(wr);
        }
#endif

        public static string PostStringBearer(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey, true);

            return ExecuteWebRequest(wr);
        }

#if NET40
        public static Task<string> PostStringBearerAsync(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "POST", apiKey, true);

            return ExecuteWebRequestAsync(wr);
        }
#endif

        public static string Delete(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "DELETE", apiKey);

            return ExecuteWebRequest(wr);
        }

#if NET40
        public static Task<string> DeleteAsync(string url, string apiKey = null)
        {
            var wr = GetWebRequest(url, "DELETE", apiKey);

            return ExecuteWebRequestAsync(wr);
        }
#endif

        internal static WebRequest GetWebRequest(string url, string method, string apiKey = null, bool useBearer = false)
        {
            apiKey = apiKey ?? StripeConfiguration.GetApiKey();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = method;

            if(!useBearer)
                request.Headers.Add("Authorization", GetAuthorizationHeaderValue(apiKey));
            else
                request.Headers.Add("Authorization", GetAuthorizationHeaderValueBearer(apiKey));

            request.Headers.Add("Stripe-Version", StripeConfiguration.ApiVersion);

            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = "Stripe.net (https://github.com/jaymedavis/stripe.net)";

            return request;
        }

        private static string GetAuthorizationHeaderValue(string apiKey)
        {
            var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:", apiKey)));
            return string.Format("Basic {0}", token);
        }

        private static string GetAuthorizationHeaderValueBearer(string apiKey)
        {
            return string.Format("Bearer {0}", apiKey);
        }

        private static string ExecuteWebRequest(WebRequest webRequest)
        {
            try
            {
                using (var response = webRequest.GetResponse())
                {
                    return ReadStream(response.GetResponseStream());
                }
            }
            catch (WebException webException)
            {
                MaybeThrowStripeExceptionFromWebException(webRequest, webException);

                throw;
            }
        }

#if NET40
        private static async Task<string> ExecuteWebRequestAsync(WebRequest webRequest)
        {
            try
            {
                var task = Task.Factory.FromAsync(webRequest.BeginGetResponse, (Func<IAsyncResult, WebResponse>)webRequest.EndGetResponse, null);
                
                using (var response = await task)
                {                    
                    return await ReadStreamAsync(response.GetResponseStream());
                }
            }
            catch (WebException webException)
            {
                MaybeThrowStripeExceptionFromWebException(webRequest, webException);

                throw;
            }
        }
#endif

        private static void MaybeThrowStripeExceptionFromWebException(WebRequest webRequest, WebException webException)
        {
                if (webException.Response != null)
                {
                    var statusCode = ((HttpWebResponse)webException.Response).StatusCode;
                    
                    var stripeError = new StripeError();

                    if (webRequest.RequestUri.ToString().Contains("oauth"))
                        stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));
                    else
                        stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

                    throw new StripeException(statusCode, stripeError, stripeError.Message);
                }
        }

        private static string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

#if NET40
        private static async Task<string> ReadStreamAsync(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }
#endif
    }
}
