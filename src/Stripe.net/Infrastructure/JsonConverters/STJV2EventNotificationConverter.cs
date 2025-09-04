#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using static Stripe.Infrastructure.SerializablePropertyCache;

    /// <summary>
    /// Converts a <see cref="V2.Event"/> to JSON, including any fields
    /// in derived classes.
    /// </summary>
    internal class STJV2EventNotificationConverter : STJDefaultConverter<V2.EventNotification>
    {
        /// <summary>
        /// Reads the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="Utf8JsonReader"/> to read from.</param>
        /// <param name="typeToConvert">Type of the object.</param>
        /// <param name="options">The calling serializer's options.</param>
        /// <returns>The object value.</returns>
        public override V2.Event Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            throw new NotSupportedException("STJV2EventConverter should only be used while serializing.");
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
            return typeof(Stripe.V2.EventNotification).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());
        }
    }
}
#endif
