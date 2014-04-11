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

			return request;
		}

		private static string[] blacklistedCertDigests = {
			// api.stripe.com
			"05C0B3643694470A888C6E7FEB5C9E24E823DC53",
			// revoked.stripe.com
			"5B7DC7FBC98D78BF76D4D4FA6F597A0C901FAD5C",
		};


		private static bool StripeCertificateVerificationCallback(
			Object sender,
			X509Certificate certificate,
			X509Chain chain,
			SslPolicyErrors sslPolicyErrors)
		{
			string cert_digest = certificate.GetCertHashString();
			if(Array.Exists(blacklistedCertDigests, digest => digest.Equals(cert_digest, StringComparison.OrdinalIgnoreCase))) {
				Console.WriteLine("Invalid server certificate: {0} ({1})", certificate.Subject, cert_digest);
				Console.WriteLine("You tried to connect to a server that has a blacklisted SSL certificate, which means we cannot securely send data to that server. Please email support@stripe.com if you need help connecting to the correct API endpoint.");
				return false;
			}

			// make sure there are no other SSL validation errors
			if(sslPolicyErrors == SslPolicyErrors.None) {
				return true;
			}

			return false;
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
			RemoteCertificateValidationCallback verification_callback = new RemoteCertificateValidationCallback(StripeCertificateVerificationCallback);
			try
			{
				ServicePointManager.ServerCertificateValidationCallback += verification_callback;
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
			 ServicePointManager.ServerCertificateValidationCallback -= verification_callback;
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
