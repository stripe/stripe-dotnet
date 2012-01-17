using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
	internal static class Mapper<T>
	{
		public static List<T> MapCollectionFromJson(string json, string token = "data")
		{
			var jObject = JObject.Parse(json);

			return jObject.SelectToken(token).Select<JToken, T>(x => MapFromJson(x.ToString())).ToList();
		}

		public static T MapFromJson(string json, string parentToken = null)
		{
			var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();

			return JsonConvert.DeserializeObject<T>(jsonToParse);
		}
	}
}