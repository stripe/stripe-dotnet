namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe.Infrastructure;

    public static class Mapper<T>
    {
        public static List<T> MapCollectionFromJson(string json, string token = "data", StripeResponse stripeResponse = null)
        {
            var jObject = JObject.Parse(json);

            var allTokens = jObject.SelectToken(token);

            return allTokens.Select(tkn => MapFromJson(tkn.ToString(), null, stripeResponse)).ToList();
        }

        public static List<T> MapCollectionFromJson(StripeResponse stripeResponse, string token = "data")
        {
            return MapCollectionFromJson(stripeResponse.ResponseJson, token, stripeResponse);
        }

        public static T MapFromJson(string json)
        {
            return MapFromJson(json, null, null);
        }

        // the ResponseJson on a list method is the entire list (as json) returned from stripe.
        // the ObjectJson is so we can store only the json for a single object in the list on that entity for
        // logging and/or debugging
        public static T MapFromJson(string json, string parentToken = null, StripeResponse stripeResponse = null)
        {
            var jsonToParse = string.IsNullOrEmpty(parentToken) ? json : JObject.Parse(json).SelectToken(parentToken).ToString();

            var converters = GetConvertersForType(typeof(T));
            var result = JsonConvert.DeserializeObject<T>(jsonToParse, converters);

            // if necessary, we might need to apply the stripe response to nested properties for StripeList<T>
            ApplyStripeResponse(json, stripeResponse, result);

            return result;
        }

        public static T MapFromJson(StripeResponse stripeResponse, string parentToken = null)
        {
            return MapFromJson(stripeResponse.ResponseJson, parentToken, stripeResponse);
        }

        public static JsonConverter[] GetConvertersForType(Type type)
        {
            List<JsonConverter> converters = new List<JsonConverter>();

            if (type == typeof(IBalanceTransactionSource))
            {
                converters.Add(new BalanceTransactionSourceConverter());
            }
            else if (type == typeof(IExternalAccount))
            {
                converters.Add(new ExternalAccountConverter());
            }
            else if (type == typeof(IPaymentSource))
            {
                converters.Add(new PaymentSourceConverter());
            }

            return converters.ToArray();
        }

        private static void ApplyStripeResponse(string json, StripeResponse stripeResponse, object obj)
        {
            if (stripeResponse == null)
            {
                return;
            }

            foreach (var property in obj.GetType().GetRuntimeProperties())
            {
                if (property.Name == nameof(StripeResponse))
                {
                    property.SetValue(obj, stripeResponse);
                }
            }

            stripeResponse.ObjectJson = json;
        }
    }
}
