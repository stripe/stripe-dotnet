namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converts a <see cref="ExpandableField{T}"/> to and from JSON.
    /// </summary>
    /// <typeparam name="T">Type of the field when expanded.</typeparam>
    public class ExpandableFieldConverter<T> : StripeObjectConverter
        where T : IHasId
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

                case IExpandableField expandableField:
                    var valueToSerialize = expandableField.IsExpanded
                        ? expandableField.ExpandedObject
                        : expandableField.Id;
                    serializer.Serialize(writer, valueToSerialize);
                    break;

                default:
                    throw new JsonSerializationException(string.Format(
                        "Unexpected value when converting ExpandableField. Expected IExpandableField, got {0}.",
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
            var value = new ExpandableField<T>();

            switch (reader.TokenType)
            {
                case JsonToken.Null:
                    // Do nothing
                    break;

                case JsonToken.String:
                    value.Id = (string)reader.Value;
                    break;

                case JsonToken.StartObject:
                    var jObject = JObject.Load(reader);

                    using (var subReader = jObject.CreateReader())
                    {
                        value.ExpandedObject = (T)base.ReadJson(
                            subReader, typeof(T), value.ExpandedObject, serializer);
                    }

                    // If we failed to deserialize the expanded object (e.g. because of an unknown
                    // type), make a last ditch attempt at getting the ID.
                    if (value.ExpandedObject == null)
                    {
                        value.Id = (string)jObject["id"];
                    }

                    break;

                default:
                    throw new JsonSerializationException(string.Format(
                        "Unexpected token when converting ExpandableField: {0}.",
                        reader.TokenType.ToString()));
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
            return typeof(IExpandableField).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
