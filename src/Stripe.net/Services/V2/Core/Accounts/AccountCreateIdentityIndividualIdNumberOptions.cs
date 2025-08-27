// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateIdentityIndividualIdNumberOptions : INestedOptions
    {
        /// <summary>
        /// The ID number type of an individual.
        /// One of: <c>ae_eid</c>, <c>ao_nif</c>, <c>az_tin</c>, <c>bd_brc</c>, <c>bd_etin</c>,
        /// <c>bd_nid</c>, <c>br_cpf</c>, <c>cr_cpf</c>, <c>cr_dimex</c>, <c>cr_nite</c>,
        /// <c>de_stn</c>, <c>do_rcn</c>, <c>gt_nit</c>, <c>hk_id</c>, <c>kz_iin</c>, <c>mx_rfc</c>,
        /// <c>my_nric</c>, <c>mz_nuit</c>, <c>nl_bsn</c>, <c>pe_dni</c>, <c>pk_cnic</c>,
        /// <c>pk_snic</c>, <c>sa_tin</c>, <c>sg_fin</c>, <c>sg_nric</c>, <c>th_lc</c>,
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
