namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal abstract class AbstractStripeObjectConverter<T> : JsonConverter
    {
        protected abstract Dictionary<string, Func<string, T>> ObjectsToMapperFuncs { get; }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IExternalAccount);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);

            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var incoming = JObject.Load(reader);

            var obj = default(T);

            var objectName = incoming.SelectToken("object")?.ToString();

            if (this.ObjectsToMapperFuncs.ContainsKey(objectName))
            {
                var mapperFunc = this.ObjectsToMapperFuncs[objectName];
                obj = mapperFunc(incoming.ToString());
            }

            return obj;
        }
    }
}
