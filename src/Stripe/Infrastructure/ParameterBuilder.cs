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
		public static IEnumerable<KeyValuePair<string,string>> GenerateFormData( object obj)
        {
            var data = new List<KeyValuePair<string, string>>();
            foreach (var property in obj.GetType().GetProperties(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance))
            {
                foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false))
                {
                    var attr = (JsonPropertyAttribute)attribute;

                    var value = property.GetValue(obj, null);
                    if (value == null) continue;

                    if (string.Compare(attr.PropertyName, "metadata", true) == 0)
                    {
                        var metadata = (Dictionary<string, string>)value;

                        foreach (string key in metadata.Keys)
                        {
                            data.Add(new KeyValuePair<string,string>(string.Format("metadata[{0}]", key), metadata[key]));
                        }
                    }
                    else
                    {
                        data.Add(new KeyValuePair<string, string>(attr.PropertyName, value.ToString()));
                    }
                }
            }

            return data;
        }

        public static string ApplyDataToUrl(string url, IEnumerable<KeyValuePair<string,string>> urlData)
        {
            foreach (var data in urlData)
            {
                var token = "&";

                if (!url.Contains("?"))
                    token = "?";

                url = string.Format("{0}{1}{2}={3}", url, token, data.Key, HttpUtility.UrlEncode(data.Value));
            }
            return url;
        }
	}
}
