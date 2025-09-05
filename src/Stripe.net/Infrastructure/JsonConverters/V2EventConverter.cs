namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// This converter deserializes Stripe thin events, which are polymorphic and discriminated by the value
    /// of a property named "type".
    /// </summary>
    internal class V2EventConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException("V2EventConverter should only be used while deserializing.");
        }

        protected virtual Type GetConcreteType(string typeValue)
        {
            return StripeTypeRegistry.GetConcreteV2EventType(typeValue) ?? typeof(V2.Event);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var jsonObject = JObject.Load(reader);

            // For V2 events, the "type" property is the discriminant that determines the specific
            // class to deserialize into.
            var typeValue = (string)jsonObject["type"];

            Type concreteType = this.GetConcreteType(typeValue);

            using (var subReader = jsonObject.CreateReader())
            {
                var e = (V2.Event)Activator.CreateInstance(concreteType);

                if (serializer.Context.Context is DeserializationContext context)
                {
                    e.Requestor = context.Requestor;
                }

                serializer.Populate(subReader, e);
                e.SetRawJObject(jsonObject);
                return e;
            }
        }

        /// <summary>
        /// Determines whether this instance can convert the specified object type.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <returns>
        ///     <c>true</c> if this instance can convert the specified object type; otherwise, <c>false</c>.
        /// </returns>
        public override bool CanConvert(Type objectType)
        {
            return objectType.GetTypeInfo() == typeof(V2.Event);
        }
    }
}
