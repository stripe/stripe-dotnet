namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using Stripe;

    internal class ExpandableFieldConverter : JsonConverter
    {
        public override bool CanWrite => false;

        public override bool CanConvert(Type objectType)
        {
            return objectType.GetGenericTypeDefinition() == typeof(ExpandableField<>);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);
            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            ExpandableField obj = (ExpandableField)Activator.CreateInstance(objectType);

            if (reader.TokenType == JsonToken.String)
            {
                // Unexpanded case

                // Simply set Id to the string from the JSON and ExpandedObject to null
                var jValue = new JValue(reader.Value);
                obj.Id = (string)jValue;
                obj.ExpandedObject = null;
            }
            else if (reader.TokenType == JsonToken.StartObject)
            {
                // Expanded case

                // Deserialize the object from the JSON
                IHasId expandedObject = null;
                Type type = objectType.GenericTypeArguments[0];

                var incoming = JObject.Load(reader);

                expandedObject = (IHasId)JsonConvert.DeserializeObject(incoming.ToString(), type, Mapper<IHasId>.GetConvertersForType(type));

                if (expandedObject != null)
                {
                    obj.Id = expandedObject.Id;
                    obj.ExpandedObject = expandedObject;
                }
                else
                {
                    // We weren't able to deserialize the nested object, but make one last attempt
                    // at grabbing the ID from the raw JSON.
                    obj.Id = incoming.SelectToken("id")?.ToString();
                    obj.ExpandedObject = null;
                }
            }

            return obj;
        }
    }
}
