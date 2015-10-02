using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace Stripe.Infrastructure
{
    internal class DefaultRequestor : Requestor
    {
        public override string GetString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetWebRequest(url, "GET", requestOptions);

            return ExecuteWebRequest(wr);
        }

        public override string PostString(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetWebRequest(url, "POST", requestOptions);

            return ExecuteWebRequest(wr);
        }

        public override string Delete(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetWebRequest(url, "DELETE", requestOptions);

            return ExecuteWebRequest(wr);
        }

        public override string PostStringBearer(string url, StripeRequestOptions requestOptions)
        {
            var wr = GetWebRequest(url, "POST", requestOptions, true);

            return ExecuteWebRequest(wr);
        }

        internal WebRequest GetWebRequest(string url, string method, StripeRequestOptions requestOptions, bool useBearer = false)
        {
            requestOptions.ApiKey = requestOptions.ApiKey ?? StripeConfiguration.GetApiKey();

            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = method;

            foreach (var header in GetHeaders(requestOptions, useBearer))
            {
                request.Headers.Add(header.Key, header.Value);
            }

            request.ContentType = "application/x-www-form-urlencoded";
            request.UserAgent = UserAgent;

            return request;
        }

        private string ExecuteWebRequest(WebRequest webRequest)
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
                if (webException.Response != null)
                {
                    var statusCode = ((HttpWebResponse)webException.Response).StatusCode;

                    throw BuildStripeException(statusCode, webRequest.RequestUri.ToString(), ReadStream(webException.Response.GetResponseStream()));
                }

                throw;
            }
        }

        private string ReadStream(Stream stream)
        {
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
