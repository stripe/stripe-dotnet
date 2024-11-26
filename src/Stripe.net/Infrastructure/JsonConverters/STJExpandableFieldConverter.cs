#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Converts a <see cref="ExpandableField{T}"/> to and from JSON.
    /// </summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    public class STJExpandableFieldConverter<T> : JsonConverter<IExpandableField>
        where T : IHasId
    {
        public override bool HandleNull => true;

        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override IExpandableField Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var value = new ExpandableField<T>();

            switch (reader.TokenType)
            {
                case JsonTokenType.Null:
                    // Do nothing
                    break;

                case JsonTokenType.String:
                    value.Id = (string)reader.GetString();
                    break;

                case JsonTokenType.StartObject:
                    var elem = JsonElement.ParseValue(ref reader);

                    value.ExpandedObject = JsonSerializer.Deserialize<T>(elem.GetRawText(), options);

                    // If we failed to deserialize the expanded object (e.g. because of an unknown
                    // type), make a last ditch attempt at getting the ID.
                    if (value.ExpandedObject == null)
                    {
                        value.Id = elem.GetProperty("id").GetString();
                    }

                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected token when converting ExpandableField: {0}.",
                        reader.TokenType.ToString()));
            }

            return value;
        }

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="Utf8JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="options">The calling serializer's options.</param>
        public override void Write(Utf8JsonWriter writer, IExpandableField value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case null:
                    writer.WriteNullValue();
                    break;

                case IExpandableField expandableField:
                    var valueToSerialize = expandableField.IsExpanded
                        ? expandableField.ExpandedObject
                        : expandableField.Id;
                    JsonSerializer.Serialize(writer, valueToSerialize, options);
                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected value when converting ExpandableField. Expected IExpandableField, got {0}.",
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
            return typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
#endif
