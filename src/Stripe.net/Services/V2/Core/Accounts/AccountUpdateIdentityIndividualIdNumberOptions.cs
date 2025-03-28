// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateIdentityIndividualIdNumberOptions : INestedOptions
    {
        /// <summary>
        /// The ID number type of an individual.
        /// One of: <c>ae_eid</c>, <c>br_cpf</c>, <c>de_stn</c>, <c>hk_id</c>, <c>mx_rfc</c>,
        /// <c>my_nric</c>, <c>nl_bsn</c>, <c>sg_fin</c>, <c>sg_nric</c>, <c>th_lc</c>,
        /// <c>th_pin</c>, <c>us_itin</c>, <c>us_itin_last_4</c>, <c>us_ssn</c>, or
        /// <c>us_ssn_last_4</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// The value of the ID number.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
