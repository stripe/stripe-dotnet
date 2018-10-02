namespace Stripe.Infrastructure
{
    using System;
    using Newtonsoft.Json.Linq;

    internal static class StringOrObject<T>
        where T : StripeEntityWithId
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
                updateId(item.Id);
                updateObject(item);
            }
            else if (value is string)
            {
                updateId((string)value);
                updateObject(null);
            }
        }
    }
}
