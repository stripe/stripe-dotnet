// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsChOptions : INestedOptions
    {
        /// <summary>
        /// Options for the standard registration.
        /// </summary>
        [JsonProperty("standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("standard")]
#endif
        public RegistrationCountryOptionsChStandardOptions Standard { get; set; }

        /// <summary>
        /// Type of registration to be created in <c>country</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
