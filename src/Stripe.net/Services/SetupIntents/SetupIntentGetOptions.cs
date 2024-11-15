// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the SetupIntent. We require this string if you use a publishable
        /// key to retrieve the SetupIntent.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif

        public string ClientSecret { get; set; }
    }
}
