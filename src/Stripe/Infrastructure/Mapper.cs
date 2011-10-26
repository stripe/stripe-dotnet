using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace Stripe
{
    internal static class Mapper<T>
    {
        public static List<string> MapCollectionToObjectList(string json)
        {
            var jObject = JObject.Parse(json);

            return jObject.SelectToken("data").Select(item => item.ToString()).ToList();
        }

        public static T MapFromJson(string json, string parentToken = null)
        {
            var jObject = JObject.Parse(json);

            if (parentToken == null)
                parentToken = string.Empty;

            var target = Activator.CreateInstance(typeof(T));

            var propertiesSet = false;

            foreach(var property in target.GetType().GetProperties())
            {
                foreach(var attribute in property.GetCustomAttributes(false))
                {
                    if (attribute.GetType() != typeof(StripeArgumentAttribute)) continue;
                    
                    var stripeArgumentAttribute = (StripeArgumentAttribute) attribute;

                    if (jObject.SelectToken(parentToken + stripeArgumentAttribute.Field) == null) continue;
                    
                    propertiesSet = true;
                    property.SetValue(target, GetJsonValue(jObject, parentToken + stripeArgumentAttribute.Field, property.PropertyType), null);
                }
            }

            if(propertiesSet)
                return (T)target;

            return default(T);
        }

        private static object GetJsonValue(JObject jObject, string field, Type target)
        {
            var val = jObject.SelectToken(field);

            if (target == typeof(bool) || target == typeof(bool?))
                return (bool) val;

            if ((target == typeof(DateTime) || target == typeof(DateTime?)) && val.Type == JTokenType.Integer)
                return new DateTime(1970, 1, 1).AddSeconds((int)val);

            if (target == typeof(DateTime) || target == typeof(DateTime?))
                return DateTime.Parse(val.ToString());

            if (target == typeof(Int32) || target == typeof(Int32?))
                return (int) val;

            return val.ToString();
        }
    }
}
