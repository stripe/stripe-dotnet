// File copied from our code generator; changes here will be overwritten.
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using static Stripe.Infrastructure.SerializablePropertyCache;

    /// <summary>
    /// Converts a <see cref="V2.Core.EventNotification"/> to and from JSON, including any fields
    /// in derived classes. Uses the "type" property for polymorphic dispatch
    /// via <see cref="StripeTypeRegistry.GetConcreteV2EventNotificationType"/>.
    /// </summary>
    internal class STJV2EventNotificationConverter : STJDefaultConverter<V2.Core.EventNotification>
    {
        /// <summary>
        /// Reads the JSON representation of the object. Uses the "type" property
        /// to determine the concrete EventNotification class to deserialize into.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override V2.Core.EventNotification Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            // Buffer the JSON so we can peek at the "type" property
            var jsonElement = JsonElement.ParseValue(ref reader);

            // Determine the concrete type from the "type" property
            string typeValue = null;
            if (jsonElement.TryGetProperty("type", out var typeProp))
            {
                typeValue = typeProp.GetString();
            }

            Type concreteType = StripeTypeRegistry.GetConcreteV2EventNotificationType(typeValue)
                ?? typeof(Events.UnknownEventNotification);

            // Deserialize using ReadFullObject with the concrete type.
            var rawJson = jsonElement.GetRawText();
            var bytes = Encoding.UTF8.GetBytes(rawJson);
            var newReader = new Utf8JsonReader(bytes, new JsonReaderOptions
            {
                AllowTrailingCommas = options.AllowTrailingCommas,
                CommentHandling = options.ReadCommentHandling,
                MaxDepth = options.MaxDepth,
            });

            // Advance to the first token (StartObject)
            newReader.Read();

            return this.ReadFullObject(ref newReader, concreteType, options);
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
            return typeof(Stripe.V2.Core.EventNotification).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
