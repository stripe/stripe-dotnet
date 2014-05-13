using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using Stripe.FastMember;
using Stripe.Infrastructure;

namespace Stripe
{
	internal static class ParameterBuilder
	{
		public static string ApplyAllParameters(object obj, string url)
		{
			if (obj == null) return url;

			var newUrl = url;

		    var descriptor = TypeAccessor.Create(obj.GetType());
            foreach (var property in descriptor.PropertyInfos)
			{
				foreach (var attribute in property.GetCustomAttributes(typeof(JsonPropertyAttribute), false).Cast<JsonPropertyAttribute>())
				{
                    var value = descriptor[obj, property.Name];
                    if (value == null) continue;

					if (System.String.Compare(attribute.PropertyName, "metadata", System.StringComparison.OrdinalIgnoreCase) == 0)
					{
						var metadata = (Dictionary<string, string>)value;

						foreach (var key in metadata.Keys)
						{
							newUrl = ApplyParameterToUrl(newUrl, string.Format("metadata[{0}]", key), metadata[key]);
						}
					}
					else if (property.PropertyType == typeof(StripeDateFilter))
					{
						var filter = (StripeDateFilter) value;

						if (filter.EqualTo.HasValue)
							newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, filter.EqualTo.Value.ConvertDateTimeToEpoch().ToString(CultureInfo.InvariantCulture));
						else
							if (filter.LessThan.HasValue)
								newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[lt]", filter.LessThan.Value.ConvertDateTimeToEpoch().ToString(CultureInfo.InvariantCulture));

							if (filter.LessThanOrEqual.HasValue)
								newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[lte]", filter.LessThanOrEqual.Value.ConvertDateTimeToEpoch().ToString(CultureInfo.InvariantCulture));

							if (filter.GreaterThan.HasValue)
								newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[gt]", filter.GreaterThan.Value.ConvertDateTimeToEpoch().ToString(CultureInfo.InvariantCulture));

							if (filter.GreaterThanOrEqual.HasValue)
								newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName + "[gte]", filter.GreaterThanOrEqual.Value.ConvertDateTimeToEpoch().ToString());
					}
					else
					{
						newUrl = ApplyParameterToUrl(newUrl, attribute.PropertyName, value.ToString());
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
