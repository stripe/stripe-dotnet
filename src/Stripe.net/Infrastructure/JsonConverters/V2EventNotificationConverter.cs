namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// This converter deserializes Stripe Event Notifications, which are polymorphic and discriminated by the value
    /// of a property named "type".
    /// </summary>
    internal class V2EventNotificationConverter : V2EventConverter
    {
        // mostly copied from the parent, but with different types
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            var jsonObject = JObject.Load(reader);

            // For V2 events, the "type" property is the discriminant that determines the specific
            // class to deserialize into.
            var typeValue = (string)jsonObject["type"];

            Type concreteType = StripeTypeRegistry.GetConcreteV2EventNotificationType(typeValue) ?? typeof(V2.UnknownEventNotification);

            using var subReader = jsonObject.CreateReader();
            var e = Activator.CreateInstance(concreteType);
            serializer.Populate(subReader, e);
            return e;
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
            return objectType.GetTypeInfo() == typeof(V2.EventNotification);
        }
    }
}
