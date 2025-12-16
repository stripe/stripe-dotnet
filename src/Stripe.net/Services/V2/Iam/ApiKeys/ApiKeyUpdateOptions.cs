// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ApiKeyUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Name to set for the API key. If blank, the field is left unchanged.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// Note or description to set for the API key. If blank, the field is left unchanged.
        /// </summary>
        [JsonProperty("note")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("note")]
#endif
        public string Note { get; set; }
    }
}
