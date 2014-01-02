using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Reflection;
using System.Web;
using Newtonsoft.Json;

namespace Stripe
{
	internal static class ParameterBuilder
	{
		public static string ApplyAllParameters(object obj, string url)
		{
			if (obj == null) return url;

			var newUrl = url;

			foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
			{
				foreach (var attribute in property.GetCustomAttributes(false))
				{
					if (attribute.GetType() != typeof(JsonPropertyAttribute)) continue;

					var JsonPropertyAttribute = (JsonPropertyAttribute)attribute;

					var value = property.GetValue(obj, null);

                    if (value != null)
                    {
                        // metadata property gets treated differently
                        if ((string.Compare(JsonPropertyAttribute.PropertyName, "metadata", true) == 0)
                            && property.PropertyType == typeof(Dictionary<string, string>))
                        {
                            Dictionary<string, string> metadata = (Dictionary<string, string>)value;
                            if (metadata.Count > 10) 
                            {
                                throw new ArgumentException("No more than 10 metadata items may be supplied");
                            }
                            foreach (string key in metadata.Keys)
                            {
                                newUrl = ApplyParameterToUrl(newUrl, string.Format("metadata[{0}]", key), metadata[key]);
                            }
                        }
                        else
                        {
                            newUrl = ApplyParameterToUrl(newUrl, JsonPropertyAttribute.PropertyName, value.ToString());
                        }
                    }
                }
			}

			return newUrl;
		}

		public static string ApplyParameterToUrl(string url, string argument, string value)
		{
			var token = "&";

			if (!url.Contains("?"))
				token = "?";

			return string.Format("{0}{1}{2}={3}", url, token, argument, HttpUtility.UrlEncode(value));
		}
	}
}
