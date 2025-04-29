// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountPersonUsCfpbDataEthnicityDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The persons ethnicity.
        /// One of: <c>cuban</c>, <c>hispanic_or_latino</c>, <c>mexican</c>,
        /// <c>not_hispanic_or_latino</c>, <c>other_hispanic_or_latino</c>,
        /// <c>prefer_not_to_answer</c>, or <c>puerto_rican</c>.
        /// </summary>
        [JsonProperty("ethnicity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ethnicity")]
#endif
        public List<string> Ethnicity { get; set; }

        /// <summary>
        /// Please specify your origin, when other is selected.
        /// </summary>
        [JsonProperty("ethnicity_other")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ethnicity_other")]
#endif
        public string EthnicityOther { get; set; }
    }
}
