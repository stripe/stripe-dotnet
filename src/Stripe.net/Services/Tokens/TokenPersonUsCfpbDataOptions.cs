// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TokenPersonUsCfpbDataOptions : INestedOptions
    {
        /// <summary>
        /// The persons ethnicity details.
        /// </summary>
        [JsonProperty("ethnicity_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ethnicity_details")]
#endif
        public TokenPersonUsCfpbDataEthnicityDetailsOptions EthnicityDetails { get; set; }

        /// <summary>
        /// The persons race details.
        /// </summary>
        [JsonProperty("race_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("race_details")]
#endif
        public TokenPersonUsCfpbDataRaceDetailsOptions RaceDetails { get; set; }

        /// <summary>
        /// The persons self-identified gender.
        /// </summary>
        [JsonProperty("self_identified_gender")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("self_identified_gender")]
#endif
        public string SelfIdentifiedGender { get; set; }
    }
}
