// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsHuOptions : INestedOptions
    {
        /// <summary>
        /// Options for the standard registration.
        /// </summary>
        [JsonProperty("standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("standard")]
#endif
        public RegistrationCountryOptionsHuStandardOptions Standard { get; set; }

        /// <summary>
        /// Type of registration to be created in an EU country.
        /// One of: <c>ioss</c>, <c>oss_non_union</c>, <c>oss_union</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
