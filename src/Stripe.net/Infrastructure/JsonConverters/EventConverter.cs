namespace Stripe.Infrastructure
{
    using System;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// This converter is used to deserialize event objects regardless of which API version they're
    /// formatted with. In the general case, Stripe.net uses a specific API version
    /// (<see cref="StripeConfiguration.ApiVersion"/>), but events are a special case: when
    /// receiving an event object via a webhook notification, the object will be formatted with
    /// the Stripe account's default API version which may be different than Stripe.net's API
    /// version.
    /// </summary>
    public class EventConverter : JsonConverter
    {
        /// <summary>
        /// Gets a value indicating whether this <see cref="JsonConverter"/> can write JSON.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this <see cref="JsonConverter"/> can write JSON; otherwise, <c>false</c>.
        /// </value>
        public override bool CanWrite => false;

        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException("EventConverter should only be used while deserializing.");
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

            var jsonObject = JObject.Load(reader);

            // Handle breaking change in API version 2017-05-25:
            // Updates the `request` property on the Event object to be a hash containing the
            // request ID and the idempotency key. Previously, `request` was just the ID.
            if (jsonObject["request"].Type == JTokenType.String)
            {
                var eventRequest = new EventRequest
                {
                    Id = jsonObject["request"].Value<string>(),
                    IdempotencyKey = null,
                };

                jsonObject["request"] = JToken.FromObject(eventRequest);
            }

            // At this point, jsonObject should be formatted in a way that's compatible with
            // Stripe.net's API version.
            var value = new Event();

            using (var subReader = jsonObject.CreateReader())
            {
                serializer.Populate(subReader, value);
            }

            // Store the raw object as a JToken
            if (value.Data != null)
            {
                value.Data.RawObject = jsonObject.SelectToken("data.object");
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
            return objectType == typeof(Event);
        }
    }
}
