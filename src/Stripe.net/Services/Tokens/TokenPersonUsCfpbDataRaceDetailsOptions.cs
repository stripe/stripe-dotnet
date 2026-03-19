// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TokenPersonUsCfpbDataRaceDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The persons race.
        /// One of: <c>african_american</c>, <c>american_indian_or_alaska_native</c>, <c>asian</c>,
        /// <c>asian_indian</c>, <c>black_or_african_american</c>, <c>chinese</c>, <c>ethiopian</c>,
        /// <c>filipino</c>, <c>guamanian_or_chamorro</c>, <c>haitian</c>, <c>jamaican</c>,
        /// <c>japanese</c>, <c>korean</c>, <c>native_hawaiian</c>,
        /// <c>native_hawaiian_or_other_pacific_islander</c>, <c>nigerian</c>, <c>other_asian</c>,
        /// <c>other_black_or_african_american</c>, <c>other_pacific_islander</c>,
        /// <c>prefer_not_to_answer</c>, <c>samoan</c>, <c>somali</c>, <c>vietnamese</c>, or
        /// <c>white</c>.
        /// </summary>
        [JsonProperty("race")]
        [STJS.JsonPropertyName("race")]
        public List<string> Race { get; set; }

        /// <summary>
        /// Please specify your race, when other is selected.
        /// </summary>
        [JsonProperty("race_other")]
        [STJS.JsonPropertyName("race_other")]
        public string RaceOther { get; set; }
    }
}
