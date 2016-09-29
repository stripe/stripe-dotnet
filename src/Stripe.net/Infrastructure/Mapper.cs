using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Stripe
{
    public static class Mapper<T>
    {
        public static List<T> MapCollectionFromJson(string json, string token = "data")
        {
            var list = new List<T>();

            var jObject = JObject.Parse(json);

            var allTokens = jObject.SelectToken(token);
            foreach (var tkn in allTokens)
                list.Add(MapFromJson(tkn.ToString()));
            return list;
        }

        public static T MapFromJson(string json, string parentToken = null)
        {
            var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();

            return JsonConvert.DeserializeObject<T>(jsonToParse);
        }
    }
}