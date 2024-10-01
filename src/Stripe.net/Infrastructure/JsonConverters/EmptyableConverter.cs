namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="Emptyable{T}"/> to and from JSON.
    /// </summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    internal class EmptyableConverter<T> : JsonConverter
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
                    break;

                case Emptyable<T> emptyable:
                    if (emptyable.Empty)
                    {
                        serializer.Serialize(writer, null);
                    }
                    else
                    {
                        serializer.Serialize(writer, emptyable.Value);
                    }

                    break;

                default:
                    throw new JsonSerializationException(string.Format(
                        "Unexpected value when converting Emptyable. Expected Emptyable, got {0}.",
                        value.GetType()));
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
            if (!objectType.IsGenericType)
            {
                return false;
            }

            return typeof(Emptyable<>).GetTypeInfo().IsAssignableFrom(objectType.GetGenericTypeDefinition());
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
            throw new NotSupportedException("Cannot deserialize Emptyable objects.");
        }
    }
}
