// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenPiiOptions : INestedOptions
    {
        /// <summary>
        /// The <c>id_number</c> for the PII, in string form.
        /// </summary>
        [JsonProperty("id_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_number")]
#endif

        public string IdNumber { get; set; }
    }
}
