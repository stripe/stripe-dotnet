// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsGb : StripeEntity<RegistrationCountryOptionsGb>
    {
        [JsonProperty("standard")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("standard")]
#endif
        public RegistrationCountryOptionsGbStandard Standard { get; set; }

        /// <summary>
        /// Type of registration in <c>country</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
