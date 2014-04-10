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

		private static byte[][] blacklistedCertDigests = {
			// api.stripe.com
			new byte[]{0x05, 0xc0, 0xb3, 0x64, 0x36, 0x94, 0x47, 0x0a, 0x88, 0x8c, 0x6e, 0x7f, 0xeb, 0x5c, 0x9e, 0x24, 0xe8, 0x23, 0xdc, 0x53},
			// revoked.stripe.com
			new byte[]{0x5b, 0x7d, 0xc7, 0xfb, 0xc9, 0x8d, 0x78, 0xbf, 0x76, 0xd4, 0xd4, 0xfa, 0x6f, 0x59, 0x7a, 0x0c, 0x90, 0x1f, 0xad, 0x5c},
			// api.stripe.com
			new byte[]{0x7b, 0xbb, 0xec, 0x45, 0xcf, 0xcc, 0x84, 0x8c, 0xeb, 0xd5, 0xad, 0xe6, 0xa1, 0x6e, 0x48, 0x80, 0x5c, 0xd9, 0x54, 0x1c},
		};


		private static bool StripeCertificateVerificationCallback(
			Object sender,
			X509Certificate certificate,
			X509Chain chain,
			SslPolicyErrors sslPolicyErrors)
		{
			System.Diagnostics.Debug.WriteLine("StripeCertificateVerificationCallback 1");
			if(sslPolicyErrors != SslPolicyErrors.None) {
				return false;
			}

			System.Diagnostics.Debug.WriteLine("StripeCertificateVerificationCallback 2");
			SHA1 sha1 = SHA1.Create();
			byte[] cert_digest = sha1.ComputeHash(certificate.GetRawCertData());
			if(Array.Exists(blacklistedCertDigests, digest => Array.Equals(digest, cert_digest))) {
				return false;
			}

			System.Diagnostics.Debug.WriteLine("StripeCertificateVerificationCallback 3");
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
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = StripeCertificateVerificationCallback;
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
				//ServicePointManager.ServerCertificateValidationCallback -= StripeCertificateVerificationCallback;
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
