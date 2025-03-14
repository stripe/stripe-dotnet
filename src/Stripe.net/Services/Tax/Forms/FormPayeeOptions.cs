// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FormPayeeOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Stripe account whose forms will be retrieved.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The external reference to the payee whose forms will be retrieved.
        /// </summary>
        [JsonProperty("external_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("external_reference")]
#endif
        public string ExternalReference { get; set; }

        /// <summary>
        /// Specifies the payee type. Either <c>account</c> or <c>external_reference</c>.
        /// One of: <c>account</c>, or <c>external_reference</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
