// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenCvcUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The CVC value, in string form.
        /// </summary>
        [JsonProperty("cvc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc")]
#endif
        public string Cvc { get; set; }
    }
}
