// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyExpireOptions : BaseOptions
    {
        /// <summary>
        /// Duration in minutes before the key expires (defaults to immediate).
        /// </summary>
        [JsonProperty("expire_in_minutes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expire_in_minutes")]
#endif
        public long? ExpireInMinutes { get; set; }
    }
}
