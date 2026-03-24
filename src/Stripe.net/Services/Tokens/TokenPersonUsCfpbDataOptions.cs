// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenPersonUsCfpbDataOptions : INestedOptions
    {
        /// <summary>
        /// The persons ethnicity details.
        /// </summary>
        [JsonProperty("ethnicity_details")]
        [STJS.JsonPropertyName("ethnicity_details")]
        public TokenPersonUsCfpbDataEthnicityDetailsOptions EthnicityDetails { get; set; }

        /// <summary>
        /// The persons race details.
        /// </summary>
        [JsonProperty("race_details")]
        [STJS.JsonPropertyName("race_details")]
        public TokenPersonUsCfpbDataRaceDetailsOptions RaceDetails { get; set; }

        /// <summary>
        /// The persons self-identified gender.
        /// </summary>
        [JsonProperty("self_identified_gender")]
        [STJS.JsonPropertyName("self_identified_gender")]
        public string SelfIdentifiedGender { get; set; }
    }
}
