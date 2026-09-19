// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RegistrationCountryOptionsLt : StripeEntity<RegistrationCountryOptionsLt>
    {
        [JsonProperty("igic")]
        [STJS.JsonPropertyName("igic")]
        public RegistrationCountryOptionsLtIgic Igic { get; set; }

        [JsonProperty("standard")]
        [STJS.JsonPropertyName("standard")]
        public RegistrationCountryOptionsLtStandard Standard { get; set; }

        /// <summary>
        /// Type of registration in an EU country.
        /// One of: <c>ioss</c>, <c>oss_non_union</c>, <c>oss_union</c>, or <c>standard</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
