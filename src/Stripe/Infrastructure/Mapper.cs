using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Stripe
{
	public static class Mapper<T>
	{
		public static IEnumerable<T> MapCollectionFromJson(string json, string token = "data")
		{
		    var jObject = JObject.Parse(json);

			var allTokens = jObject.SelectToken(token);

		    return allTokens.Select(tkn => MapFromJson(tkn.ToString()));
		}

		public static T MapFromJson(string json, string parentToken = null)
		{
			var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();

			return JsonConvert.DeserializeObject<T>(jsonToParse);
		}
	}
}