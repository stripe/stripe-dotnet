namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// This converter can be used to deserialize any Stripe object. It is mainly useful for
    /// polymorphic attributes, when the property's type is an interface instead of a concrete type.
    /// In this case, the converter will use the value of the `object` key in the JSON payload to
    /// decide which concrete type to instantiate. If no concrete type is found (or if one is found,
    /// but it's not compatible with the expected interface), then the converter returns `null`.
    /// </summary>
    public class StripeObjectConverter : JsonConverter
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="JsonConverter"/> can write JSON.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this <see cref="JsonConverter"/> can write JSON; otherwise, <c>false</c>.
        /// </value>
        public override bool CanWrite => false;

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException("StripeObjectConverter should only be used while deserializing.");
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="JsonReader"/> to read from.</param>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="existingValue">The existing value of object being read.</param>
        /// <param name="serializer">The calling serializer.</param>
        /// <returns>The object value.</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var jsonObject = JObject.Load(reader);
            var objectValue = (string)jsonObject["object"];

            Type concreteType = StripeTypeRegistry.GetConcreteType(objectType, objectValue);
            if (concreteType == null)
            {
                // Couldn't find a concrete type to instantiate, return null.
                return null;
            }

            var value = Activator.CreateInstance(concreteType);

            using (var subReader = jsonObject.CreateReader())
            {
                serializer.Populate(subReader, value);
            }

            return value;
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
            return objectType.GetTypeInfo().IsInterface;
        }
    }
}
