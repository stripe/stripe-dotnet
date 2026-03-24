// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationCountryOptionsDkOptions : INestedOptions
    {
        /// <summary>
        /// Options for the standard registration.
        /// </summary>
        [JsonProperty("standard")]
        [STJS.JsonPropertyName("standard")]
        public RegistrationCountryOptionsDkStandardOptions Standard { get; set; }

        /// <summary>
        /// Type of registration to be created in an EU country.
        /// One of: <c>ioss</c>, <c>oss_non_union</c>, <c>oss_union</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
