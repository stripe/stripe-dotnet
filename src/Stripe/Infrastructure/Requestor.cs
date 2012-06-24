using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

namespace Stripe
{
	internal static class Requestor
	{
		public static string GetString(string url, string apiKey = null)
		{
			var wr = GetWebRequest(url, "GET", apiKey);

			return ExecuteWebRequest(wr);
		}

		public static string PostString(string url, string apiKey = null)
		{
			var wr = GetWebRequest(url, "POST", apiKey);

			return ExecuteWebRequest(wr);
		}

		public static string Delete(string url, string apiKey = null)
		{
			var wr = GetWebRequest(url, "DELETE", apiKey);

			return ExecuteWebRequest(wr);
		}

		private static WebRequest GetWebRequest(string url, string method, string apiKey = null)
		{
            // If an API key is provided, we use it. Otherwise, we look for the API key in the application settings
		    apiKey = apiKey ?? ConfigurationManager.AppSettings["StripeApiKey"];

			var request = (HttpWebRequest) WebRequest.Create(url);
			request.Method = method;
			request.Headers.Add("Authorization", GetAuthorizationHeaderValue(apiKey));
			request.ContentType = "application/x-www-form-urlencoded";
			request.UserAgent = "Stripe.net (https://github.com/jaymedavis/stripe.net)";

			return request;
		}

		private static string GetAuthorizationHeaderValue(string apiKey)
		{
			var token = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Format("{0}:", apiKey)));
			return string.Format("Basic {0}", token);
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
					var stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

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