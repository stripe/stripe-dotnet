namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json.Linq;

    internal static class StringOrObject<T>
        where T : IHasId
    {
        public static void Map(object value, Action<string> updateId, Action<T> updateObject)
        {
            if (value is JObject)
            {
                // We reserialize the JObject instance to a string so we can pass it to the Mapper
                // class. This ensures our custom deserialization / converters are used even when
                // deserializing expanded fields.
                // TODO: We could probably avoid the unnecessary deserialization+reserialization
                // with some refactoring.
                T item = Mapper<T>.MapFromJson(value.ToString());

                if (item != null)
                {
                    updateId(item.Id);
                    updateObject(item);
                }
                else
                {
                    // We were unable to deserialize the object, but make a last attempt to grab
                    // the ID from the raw JObject.
                    var id = ((JObject)value).SelectToken("id")?.ToString();
                    updateId(id);
                    updateObject(default(T));
                }
            }
            else if (value is string)
            {
                updateId((string)value);
                updateObject(default(T));
            }
        }
    }
}
