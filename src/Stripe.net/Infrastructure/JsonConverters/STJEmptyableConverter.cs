#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="Emptyable{T}"/> to and from JSON.
    /// </summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    internal class STJEmptyableConverter<T> : JsonConverter<Emptyable<T>>
    {
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The calling serializer's options.</param>
        public override void Write(Utf8JsonWriter writer, Emptyable<T> value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    break;

                case Emptyable<T> emptyable:
                    if (emptyable.Empty)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        JsonSerializer.Serialize(writer, emptyable.Value, options);
                    }

                    break;

                default:
                    throw new JsonException(string.Format(
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

            return typeof(IEmptyable).GetTypeInfo().IsAssignableFrom(objectType.GetGenericTypeDefinition());
        }

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override Emptyable<T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException("Cannot deserialize Emptyable objects.");
        }
    }
}
#endif
