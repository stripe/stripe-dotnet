// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PersonUsCfpbDataEthnicityDetails : StripeEntity<PersonUsCfpbDataEthnicityDetails>
    {
        /// <summary>
        /// The persons ethnicity.
        /// One of: <c>cuban</c>, <c>hispanic_or_latino</c>, <c>mexican</c>,
        /// <c>not_hispanic_or_latino</c>, <c>other_hispanic_or_latino</c>,
        /// <c>prefer_not_to_answer</c>, or <c>puerto_rican</c>.
        /// </summary>
        [JsonProperty("ethnicity")]
        [STJS.JsonPropertyName("ethnicity")]
        public List<string> Ethnicity { get; set; }

        /// <summary>
        /// Please specify your origin, when other is selected.
        /// </summary>
        [JsonProperty("ethnicity_other")]
        [STJS.JsonPropertyName("ethnicity_other")]
        public string EthnicityOther { get; set; }
    }
}
