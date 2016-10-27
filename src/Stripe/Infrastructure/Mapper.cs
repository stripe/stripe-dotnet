using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Stripe
{
    public static class Mapper<T>
    {
        public static List<T> MapCollectionFromJson(string json, string token = "data")
        {
            var jObject = JObject.Parse(json);

            var allTokens = jObject.SelectToken(token);

            return allTokens.Select(tkn => MapFromJson(tkn.ToString())).ToList();
        }

        public static T MapFromJson(string json, string parentToken = null)
        {
            var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();

            var result = JsonConvert.DeserializeObject<T>(jsonToParse);

            foreach (var property in typeof(T).GetRuntimeProperties())
                if (property.Name == "StripeRawJson")
                    property.SetValue(result, json);

            return result;
        }
    }
}