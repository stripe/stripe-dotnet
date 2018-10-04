namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// This converter is used to deserialize polymorphic resources. The resources must implement
    /// a common interface.
    /// </summary>
    /// <typeparam name="I">interface implemented by all resources that this converter can
    /// return</typeparam>
    internal abstract class AbstractStripeObjectConverter<I> : JsonConverter
        where I : IHasObject
    {
        public override bool CanWrite => false;

        /// <summary>
        /// This is the only property that needs to be declared by concrete converters. It is a
        /// mapping of object names (e.g. <c>"card"</c>) to mapper functions (e.g.
        /// <c>Mapper&lt;Card&gt;.FromJson</c>).
        /// </summary>
        protected abstract Dictionary<string, Func<string, I>> ObjectsToMapperFuncs { get; }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(I);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var incoming = JObject.FromObject(value);
            incoming.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var incoming = JObject.Load(reader);
            var obj = default(I);
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
