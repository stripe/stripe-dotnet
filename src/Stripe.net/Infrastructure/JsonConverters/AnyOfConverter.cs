namespace Stripe.Infrastructure
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="IAnyOf"/> to and from JSON.
    /// </summary>
    public class AnyOfConverter : JsonConverter
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="JsonConverter"/> can write JSON.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this <see cref="JsonConverter"/> can write JSON; otherwise, <c>false</c>.
        /// </value>
        public override bool CanWrite => true;

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            switch (value)
            {
                case null:
                    serializer.Serialize(writer, null);
                    break;

                case IAnyOf anyOf:
                    serializer.Serialize(writer, anyOf.Value);
                    break;

                default:
                    throw new JsonSerializationException(string.Format(
                        "Unexpected value when converting AnyOf. Expected IAnyOf, got {0}.",
                        value.GetType()));
            }
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

            object o = null;

            // Try to deserialize with each possible type
            var jToken = JToken.Load(reader);
            foreach (var type in objectType.GenericTypeArguments)
            {
                try
                {
                    using (var subReader = jToken.CreateReader())
                    {
                        o = serializer.Deserialize(subReader, type);
                    }

                    // If deserialization succeeds, stop
                    break;
                }
                catch (JsonException)
                {
                    // Do nothing, just try the next type
                }
            }

            if (o == null)
            {
                throw new JsonSerializationException(string.Format(
                    "Cannot deserialize the current JSON object into any of the expected types ({0}).",
                    string.Join(", ", objectType.GenericTypeArguments.Select(t => t.FullName))));
            }

            return Activator.CreateInstance(objectType, o);
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
            return typeof(IAnyOf).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
