namespace Stripe.Infrastructure
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Stripe.V2;

    /// <summary>
    /// A <see cref="JsonConverterFactory"/> that, during deserialization, injects an
    /// <see cref="ApiRequestor"/> into any entity that implements <see cref="IHasRequestor"/>.
    /// Add an instance of this factory (with the desired requestor) to a cloned
    /// <see cref="JsonSerializerOptions"/> before calling <c>JsonSerializer.Deserialize</c>.
    /// </summary>
#pragma warning disable SA1649 // File name should match first type name
    internal class STJRequestorInjectionConverterFactory : JsonConverterFactory
#pragma warning restore SA1649 // File name should match first type name
    {
        private static readonly Type IHasRequestorType = typeof(IHasRequestor);

        private readonly ApiRequestor requestor;

        public STJRequestorInjectionConverterFactory(ApiRequestor requestor)
        {
            this.requestor = requestor;
        }

        public override bool CanConvert(Type typeToConvert)
        {
            return IHasRequestorType.GetTypeInfo().IsAssignableFrom(typeToConvert.GetTypeInfo());
        }

        public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
        {
#pragma warning disable SA1009 // Closing parenthesis should be spaced correctly
            JsonConverter converter = (JsonConverter)Activator.CreateInstance(
                typeof(STJRequestorInjectionConverter<>).MakeGenericType(type),
                BindingFlags.Instance | BindingFlags.Public,
                binder: null,
                args: new object[] { this.requestor, this },
                culture: null)!;
#pragma warning restore SA1009 // Closing parenthesis should be spaced correctly

            return converter;
        }
    }

    /// <summary>
    /// Deserializes a <typeparamref name="T"/> using options that exclude this factory (to avoid
    /// infinite recursion), then injects the requestor.
    /// </summary>
    /// <typeparam name="T">An entity type that implements <see cref="IHasRequestor"/>.</typeparam>
#pragma warning disable SA1402 // File may only contain a single type
    internal class STJRequestorInjectionConverter<T> : JsonConverter<T>
#pragma warning restore SA1402 // File may only contain a single type
        where T : IHasRequestor
    {
        private readonly ApiRequestor requestor;
        private readonly STJRequestorInjectionConverterFactory factory;

        public STJRequestorInjectionConverter(ApiRequestor requestor, STJRequestorInjectionConverterFactory factory)
        {
            this.requestor = requestor;
            this.factory = factory;
        }

        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Build inner options with this factory removed to prevent infinite recursion.
            var innerOptions = new JsonSerializerOptions(options);
            innerOptions.Converters.Remove(this.factory);

            var result = (T)JsonSerializer.Deserialize(ref reader, typeToConvert, innerOptions);

            if (result != null)
            {
                result.Requestor = this.requestor;
            }

            return result;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, typeof(T), options);
        }
    }
}
