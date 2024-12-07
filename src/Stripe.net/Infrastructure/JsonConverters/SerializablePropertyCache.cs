#if NET6_0_OR_GREATER
namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    /// <summary>
    /// An helper class for efficiently working with serializable properties.  This class manages
    /// the data and metadata needed for many of our STJ custom converters.
    /// </summary>
    internal class SerializablePropertyCache
    {
        private static Dictionary<Type, JsonConverter> converterCache = new Dictionary<Type, JsonConverter>();
        private static Dictionary<Type, List<SerializablePropertyInfo>> propertyCache = new Dictionary<Type, List<SerializablePropertyInfo>>();

        internal static List<SerializablePropertyInfo> GetPropertiesForType(Type type)
        {
            if (!propertyCache.TryGetValue(type, out var propsToSerialize))
            {
                // Gets the all properties including nonpublic properties
                var rawProps = type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

                propsToSerialize = new List<SerializablePropertyInfo>();
                foreach (var prop in rawProps)
                {
                    var propertyNameAttribute = prop.GetCustomAttribute(typeof(JsonPropertyNameAttribute), false) as JsonPropertyNameAttribute;
                    if (propertyNameAttribute == null)
                    {
                        // skip any properties not annotated with JsonPropertyName
                        continue;
                    }

                    var ignoreCondition = default(JsonIgnoreCondition);
                    if (prop.GetCustomAttribute(typeof(JsonIgnoreAttribute), false) is JsonIgnoreAttribute ignoreAttribute)
                    {
                        if (ignoreAttribute.Condition == JsonIgnoreCondition.Always)
                        {
                            continue;
                        }

                        ignoreCondition = ignoreAttribute.Condition;
                    }

                    var customConverterAttribute = prop.GetCustomAttribute(typeof(JsonConverterAttribute), false) as JsonConverterAttribute;

                    propsToSerialize.Add(new SerializablePropertyInfo()
                    {
                        PropertyInfo = prop,
                        JsonPropertyName = propertyNameAttribute.Name,
                        IgnoreCondition = ignoreCondition,
                        CustomConverterType = customConverterAttribute?.ConverterType,
                    });
                }

                propertyCache[type] = propsToSerialize;
            }

            return propsToSerialize;
        }

        // Create the various methods stored in SerializablePropertyInfo
        // this uses heavy reflection so that our internals are typesafe
        // and that our converter interface is JsonConverter<object> which
        // is required because JsonConverter does not expose Read or Write.
        internal class SerializablePropertyInfo
        {
            private static MethodInfo createGetDelegateMethod = typeof(SerializablePropertyInfo).GetMethod("CreateGetDelegate", BindingFlags.Static | BindingFlags.NonPublic);
            private static MethodInfo createSetDelegateMethod = typeof(SerializablePropertyInfo).GetMethod("CreateSetDelegate", BindingFlags.Static | BindingFlags.NonPublic);
            private static MethodInfo getConverterForTypeMethod = typeof(SerializablePropertyInfo).GetMethod("GetConverterForType", BindingFlags.Static | BindingFlags.NonPublic);
            private static MethodInfo getDefaultConverterMethod = typeof(SerializablePropertyInfo).GetMethod("GetDefaultConverter", BindingFlags.Static | BindingFlags.NonPublic);

            private Func<object, object> getDelegate = null;
            private Action<object, object> setDelegate = null;
            private Func<JsonSerializerOptions, JsonConverter<object>> getConverter = null;

            /// <summary>
            /// The PropertyInfo object that describes this property.
            /// </summary>
            internal PropertyInfo PropertyInfo { get; set; }

            /// <summary>
            /// The JSON property name for this property.
            /// </summary>
            internal string JsonPropertyName { get; set; }

            /// <summary>
            /// The condition under which to ignore this property, or null
            /// if JsonIgnore is not found.
            /// </summary>
            internal JsonIgnoreCondition? IgnoreCondition { get; set; }

            internal Type CustomConverterType { get; set; }

            /// <summary>
            /// Gets the converter to use to convert this property, either
            /// a custom one from the attribute or the converter returned
            /// from the STJ serialization options.
            /// </summary>
            internal JsonConverter<object> GetConverter(JsonSerializerOptions options)
            {
                if (this.getConverter == null)
                {
                    var customConverter = default(JsonConverter<object>);
                    if (this.CustomConverterType != null)
                    {
                        // this assumes any property-level JsonConverter attribute
                        // specifies a JsonConverter<> type and not a JsonConverterFactory
                        // type
                        var baseType = this.CustomConverterType.BaseType;
                        var cvtGenericMethod = getConverterForTypeMethod.MakeGenericMethod(baseType, baseType.GenericTypeArguments[0]);
                        customConverter = (JsonConverter<object>)cvtGenericMethod.Invoke(null, new object[] { this.CustomConverterType });
                    }

                    var defaultCvtGenericMethod = getDefaultConverterMethod.MakeGenericMethod(this.PropertyInfo.PropertyType);
                    var getDefaultConverter = (Func<JsonSerializerOptions, JsonConverter<object>>)defaultCvtGenericMethod.Invoke(null, new object[] { this.PropertyInfo.PropertyType });
                    this.getConverter = options => customConverter ?? getDefaultConverter(options);
                }

                return this.getConverter(options);
            }

            /// <summary>
            /// A fast GetValue method.
            /// </summary>
            internal object Get(object obj)
            {
                if (this.getDelegate == null)
                {
                    var gm = this.PropertyInfo.GetGetMethod(true);
                    var getMethod = createGetDelegateMethod.MakeGenericMethod(this.PropertyInfo.DeclaringType, this.PropertyInfo.PropertyType);
                    this.getDelegate = (Func<object, object>)getMethod.Invoke(null, new object[] { gm });
                }

                return this.getDelegate(obj);
            }

            /// <summary>
            /// A fast SetValue method.
            /// </summary>
            internal void Set(object obj, object value)
            {
                if (this.setDelegate == null)
                {
                    var sm = this.PropertyInfo.GetSetMethod(true);
                    var setMethod = createSetDelegateMethod.MakeGenericMethod(this.PropertyInfo.DeclaringType, this.PropertyInfo.PropertyType);
                    this.setDelegate = (Action<object, object>)setMethod.Invoke(null, new object[] { sm });
                }

                this.setDelegate(obj, value);
            }

            // These are used via reflection, so don't warn
#pragma warning disable IDE0051 // Remove unused private members
            private static Func<object, object> CreateGetDelegate<T, TReturn>(MethodInfo m)
            {
                var f = (Func<T, TReturn>)Delegate.CreateDelegate(typeof(Func<T, TReturn>), m);
                return t => f((T)t);
            }

            private static Action<object, object> CreateSetDelegate<T, TValue>(MethodInfo m)
            {
                var f = (Action<T, TValue>)Delegate.CreateDelegate(typeof(Action<T, TValue>), m);
                return (t, v) => f((T)t, (TValue)v);
            }

            private static JsonConverter<object> GetConverterForType<T, TV>(Type ct)
            where T : JsonConverter<TV>
            {
                if (!converterCache.TryGetValue(ct, out var conv))
                {
                    conv = (JsonConverter)Activator.CreateInstance(ct);
                    converterCache[ct] = conv;
                }

                return new JsonConverterAdapter<T, TV>((T)conv);
            }

            private static Func<JsonSerializerOptions, JsonConverter<object>> GetDefaultConverter<TV>(Type t)
            {
                return options => new JsonConverterAdapter<JsonConverter<TV>, TV>((JsonConverter<TV>)options.GetConverter(t));
            }
#pragma warning restore IDE0051 // Remove unused private members

        }

        internal class JsonConverterAdapter<T, TV> : JsonConverter<object>
        where T : JsonConverter<TV>
        {
            private T inner;

            internal JsonConverterAdapter(T inner)
            {
                this.inner = inner;
            }

            public override object Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                return this.inner.Read(ref reader, typeToConvert, options);
            }

            public override void Write(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
            {
                this.inner.Write(writer, (TV)value, options);
            }
        }
    }
}
#endif
