namespace Stripe.Infrastructure
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using Newtonsoft.Json;

    internal static class JsonUtils
    {
        /// <summary>
        /// Deserializes the JSON to the specified .NET type using
        /// <see cref="JsonSerializerSettings"/>.
        /// </summary>
        /// <typeparam name="T">The type of the object to deserialize to.</typeparam>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="settings">
        /// The <see cref="JsonSerializerSettings"/> used to deserialize the object.
        /// </param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static T DeserializeObject<T>(
            string value,
            JsonSerializerSettings settings = null)
        {
            return (T)DeserializeObject(value, typeof(T), settings);
        }

        /// <summary>
        /// Deserializes the JSON to the specified .NET type using
        /// <see cref="JsonSerializerSettings"/>.
        /// </summary>
        /// <param name="value">The JSON to deserialize.</param>
        /// <param name="type">The type of the object to deserialize to.</param>
        /// <param name="settings">
        /// The <see cref="JsonSerializerSettings"/> used to deserialize the object.
        /// </param>
        /// <returns>The deserialized object from the JSON string.</returns>
        public static object DeserializeObject(
            string value,
            Type type,
            JsonSerializerSettings settings = null)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            JsonSerializer jsonSerializer = JsonSerializer.Create(settings);

            using (JsonTextReader reader = new JsonTextReader(new StringReader(value)))
            {
                return jsonSerializer.Deserialize(reader, type);
            }
        }

        /// <summary>
        /// Serializes the specified object to a JSON string without using any default settings.
        /// </summary>
        /// <param name="value">The object to serialize.</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <param name="settings">
        /// The <see cref="JsonSerializerSettings"/> used to serialize the object.
        /// </param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string SerializeObject(
            object value,
            Formatting formatting = Formatting.None,
            JsonSerializerSettings settings = null)
        {
            JsonSerializer jsonSerializer = JsonSerializer.Create(settings);
            jsonSerializer.Formatting = formatting;

            StringBuilder sb = new StringBuilder(256);
            StringWriter sw = new StringWriter(sb, CultureInfo.InvariantCulture);
            using (JsonTextWriter jsonWriter = new JsonTextWriter(sw))
            {
                jsonWriter.Formatting = jsonSerializer.Formatting;

                jsonSerializer.Serialize(jsonWriter, value);
            }

            return sw.ToString();
        }
    }
}
