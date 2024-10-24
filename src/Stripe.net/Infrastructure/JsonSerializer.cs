namespace Stripe.Infrastructure
{
    using System;
    using System.Text.Json;
    using Newtonsoft.Json;

    public interface IJsonSerializer
    {
        string SerializeObject(object value);
        T DeserializeObject<T>(string value);
    }

    public class NewtonsoftJsonSerializer : IJsonSerializer
    {
        public string SerializeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public T DeserializeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }
    }

    public class SystemTextJsonSerializer : IJsonSerializer
    {
        private readonly JsonSerializerOptions options;

        public SystemTextJsonSerializer()
        {
            this.options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }

        public string SerializeObject(object value)
        {
            return JsonSerializer.Serialize(value, this.options);
        }

        public T DeserializeObject<T>(string value)
        {
            return JsonSerializer.Deserialize<T>(value, this.options);
        }
    }
}
