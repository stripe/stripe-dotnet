using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

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

		public static string PostStringBearer(string url, string apiKey = null)
		{
			var wr = GetWebRequest(url, "POST", apiKey, true);

			return ExecuteWebRequest(wr);
		}

		public static string Delete(string url, string apiKey = null)
		{
			var wr = GetWebRequest(url, "DELETE", apiKey);

			return ExecuteWebRequest(wr);
		}

		private static WebRequest GetWebRequest(string url, string method, string apiKey = null, bool useBearer = false)
		{
			apiKey = apiKey ?? StripeConfiguration.GetApiKey();

			var request = (HttpWebRequest)WebRequest.Create(url);
			request.Method = method;

			if(!useBearer)
				request.Headers.Add("Authorization", GetAuthorizationHeaderValue(apiKey));
			else
				request.Headers.Add("Authorization", GetAuthorizationHeaderValueBearer(apiKey));

			request.ContentType = "application/x-www-form-urlencoded";
			request.UserAgent = "Stripe.net (https://github.com/jaymedavis/stripe.net)";

			//// this only works for .NET 4.5+, unfortunately :(
			//request.ServerCertificateValidationCallback = StripeCertificateVerificationCallback;

			return request;
		}

		private static string[] blacklistedCertDigests = {
			// api.stripe.com
			"05C0B3643694470A888C6E7FEB5C9E24E823DC53",
			// REVOKED.STRIPE.COM
			"5B7DC7FBC98D78BF76D4D4FA6F597A0C901FAD5C",
			// api.stripe.com
			//"7BBBEC45CFCC848CEBD5ADE6A16E48805CD9541C",
		};


		private static bool StripeCertificateVerificationCallback(
			Object sender,
			X509Certificate certificate,
			X509Chain chain,
			SslPolicyErrors sslPolicyErrors)
		{
			Console.WriteLine("StripeCertificateVerificationCallback 1");
			if(sslPolicyErrors != SslPolicyErrors.None) {
        Console.WriteLine("StripeCertificateVerificationCallback 1b");
				return false;
			}

			Console.WriteLine("StripeCertificateVerificationCallback 2");
			string cert_digest = certificate.GetCertHashString();
			if(Array.Exists(blacklistedCertDigests, digest => digest.Equals(cert_digest, StringComparison.OrdinalIgnoreCase))) {
        Console.WriteLine("StripeCertificateVerificationCallback 2b");
				return false;
			}

			Console.WriteLine("StripeCertificateVerificationCallback 3");
			return true;
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
      Console.WriteLine("CREATING DELEGATE");
      var del = new RemoteCertificateValidationCallback(StripeCertificateVerificationCallback);
			try
			{
        Console.WriteLine("ASSIGNING DELEGATE");
        ServicePointManager.ServerCertificateValidationCallback += del;
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
					
					var stripeError = new StripeError();

					if(webRequest.RequestUri.ToString().Contains("oauth"))
						stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()));
					else
						stripeError = Mapper<StripeError>.MapFromJson(ReadStream(webException.Response.GetResponseStream()), "error");

					throw new StripeException(statusCode, stripeError, stripeError.Message);
				}

				throw;
			}
			finally
			{
       Console.WriteLine("UN-ASSIGNING DELEGATE");
			 ServicePointManager.ServerCertificateValidationCallback -= del;
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
