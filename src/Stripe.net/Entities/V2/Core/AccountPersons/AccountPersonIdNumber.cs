// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountPersonIdNumber : StripeEntity<AccountPersonIdNumber>
    {
        /// <summary>
        /// The ID number type of an individual.
        /// One of: <c>ae_eid</c>, <c>ao_nif</c>, <c>ar_cuil</c>, <c>ar_dni</c>, <c>at_stn</c>,
        /// <c>az_tin</c>, <c>bd_brc</c>, <c>bd_etin</c>, <c>bd_nid</c>, <c>be_nrn</c>,
        /// <c>bg_ucn</c>, <c>bn_nric</c>, <c>br_cpf</c>, <c>ca_sin</c>, <c>ch_oasi</c>,
        /// <c>cl_rut</c>, <c>cn_pp</c>, <c>co_nuip</c>, <c>cr_ci</c>, <c>cr_cpf</c>,
        /// <c>cr_dimex</c>, <c>cr_nite</c>, <c>cy_tic</c>, <c>cz_rc</c>, <c>de_stn</c>,
        /// <c>dk_cpr</c>, <c>do_cie</c>, <c>do_rcn</c>, <c>ec_ci</c>, <c>ee_ik</c>, <c>es_nif</c>,
        /// <c>fi_hetu</c>, <c>fr_nir</c>, <c>gb_nino</c>, <c>gr_afm</c>, <c>gt_nit</c>,
        /// <c>hk_id</c>, <c>hr_oib</c>, <c>hu_ad</c>, <c>id_nik</c>, <c>ie_ppsn</c>, <c>is_kt</c>,
        /// <c>it_cf</c>, <c>jp_inc</c>, <c>ke_pin</c>, <c>kz_iin</c>, <c>li_peid</c>, <c>lt_ak</c>,
        /// <c>lu_nif</c>, <c>lv_pk</c>, <c>mx_rfc</c>, <c>my_nric</c>, <c>mz_nuit</c>,
        /// <c>ng_nin</c>, <c>nl_bsn</c>, <c>no_nin</c>, <c>nz_ird</c>, <c>pe_dni</c>,
        /// <c>pk_cnic</c>, <c>pk_snic</c>, <c>pl_pesel</c>, <c>pt_nif</c>, <c>ro_cnp</c>,
        /// <c>sa_tin</c>, <c>se_pin</c>, <c>sg_fin</c>, <c>sg_nric</c>, <c>sk_dic</c>,
        /// <c>th_lc</c>, <c>th_pin</c>, <c>tr_tin</c>, <c>us_itin</c>, <c>us_itin_last_4</c>,
        /// <c>us_ssn</c>, <c>us_ssn_last_4</c>, <c>uy_dni</c>, or <c>za_id</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
