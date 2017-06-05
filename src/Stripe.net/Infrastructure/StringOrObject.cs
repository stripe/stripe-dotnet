using System;
using Newtonsoft.Json.Linq;

namespace Stripe.Infrastructure
{
    internal static class StringOrObject<T> where T : StripeEntityWithId
    {
        public static void Map(object value, Action<string> updateId, Action<T> updateObject)
        {
            if (value is JObject)
            {
                T item = ((JToken) value).ToObject<T>();
                updateId(item.Id);
                updateObject(item);
            }
            else if (value is string)
            {
                updateId((string) value);
                updateObject(null);
            }
        }
    }
}
