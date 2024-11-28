#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// A JsonConverterFactory for use with generic IExpandableField implementations
    /// to ensure we return a correctly typed custom converter.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    public class STJExpandableFieldConverterFactory : JsonConverterFactory
#pragma warning restore SA1649 // File name should match first type name
    {
        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(typeToConvert.GetTypeInfo());
        }

        public override JsonConverter CreateConverter(
            Type type,
            JsonSerializerOptions options)
        {
            Type[] typeArguments = type.GetGenericArguments();
            Type fieldType = typeArguments[0];

#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJExpandableFieldConverter<>).MakeGenericType(
                    fieldType),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: null,
                culture: null)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

            return converter;
        }
    }

    /// <summary>
    /// Converts a <see cref="ExpandableField{T}"/> to and from JSON.
    /// </summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
#pragma warning disable SA1402 // File may only contain a single type
    public class STJExpandableFieldConverter<T> : JsonConverter<IExpandableField>
#pragma warning restore SA1402 // File may only contain a single type
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

                    value.ExpandedObject = (T)JsonSerializer.Deserialize(elem.GetRawText(), typeToConvert.GenericTypeArguments[0], options);

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
                    if (expandableField.IsExpanded)
                    {
                        JsonSerializer.Serialize(writer, expandableField.ExpandedObject, options);
                    }
                    else
                    {
                        writer.WriteStringValue(expandableField.Id);
                    }

                    break;

                default:
                    throw new JsonException(string.Format(
                        "Unexpected value when converting ExpandableField. Expected IExpandableField, got {0}.",
                        value.GetType()));
            }
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(typeToConvert.GetTypeInfo());
        }
    }
}
#endif
