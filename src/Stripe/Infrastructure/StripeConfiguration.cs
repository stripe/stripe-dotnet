using System;
using System.Configuration;

namespace Stripe
{
	public static class StripeConfiguration
	{
		private static string _apiKey;
		private static string _apiVersion;

		internal static string GetApiKey()
		{
			if (string.IsNullOrEmpty(_apiKey))
				_apiKey = ConfigurationManager.AppSettings["StripeApiKey"];

			return _apiKey;
		}

		public static void SetApiKey(string newApiKey)
		{
			_apiKey = newApiKey;
		}

		internal static string GetApiVersion()
		{
			if (string.IsNullOrEmpty(_apiVersion))
				_apiVersion = ConfigurationManager.AppSettings["StripeApiVersion"];

			return _apiVersion;
		}
	}
}
