// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateIdentityIndividualIdNumberOptions : INestedOptions
    {
        /// <summary>
        /// The ID number type of an individual.
        /// One of: <c>ae_eid</c>, <c>ao_nif</c>, <c>ar_cuil</c>, <c>ar_dni</c>, <c>at_stn</c>,
        /// <c>az_tin</c>, <c>bd_brc</c>, <c>bd_etin</c>, <c>bd_nid</c>, <c>be_nrn</c>,
        /// <c>bg_ucn</c>, <c>bm_pp</c>, <c>bn_nric</c>, <c>bo_ci</c>, <c>br_cpf</c>, <c>bt_cid</c>,
        /// <c>ca_sin</c>, <c>ch_oasi</c>, <c>cl_rut</c>, <c>cn_pp</c>, <c>co_nuip</c>,
        /// <c>cr_ci</c>, <c>cr_cpf</c>, <c>cr_dimex</c>, <c>cr_nite</c>, <c>cy_tic</c>,
        /// <c>cz_rc</c>, <c>de_stn</c>, <c>dk_cpr</c>, <c>do_cie</c>, <c>do_rcn</c>, <c>ec_ci</c>,
        /// <c>ee_ik</c>, <c>eg_tin</c>, <c>es_nif</c>, <c>fi_hetu</c>, <c>fr_nir</c>,
        /// <c>gb_nino</c>, <c>gh_pin</c>, <c>gr_afm</c>, <c>gt_nit</c>, <c>gy_tin</c>,
        /// <c>hk_id</c>, <c>hn_rtn</c>, <c>hr_oib</c>, <c>hu_ad</c>, <c>id_nik</c>, <c>ie_ppsn</c>,
        /// <c>is_kt</c>, <c>it_cf</c>, <c>jm_trn</c>, <c>jo_pin</c>, <c>jp_inc</c>, <c>ke_pin</c>,
        /// <c>ky_pp</c>, <c>kz_iin</c>, <c>li_peid</c>, <c>lk_nic</c>, <c>lt_ak</c>, <c>lu_nif</c>,
        /// <c>lv_pk</c>, <c>mo_bir</c>, <c>mt_nic</c>, <c>mv_tin</c>, <c>mx_rfc</c>,
        /// <c>my_nric</c>, <c>mz_nuit</c>, <c>ng_nin</c>, <c>nl_bsn</c>, <c>no_nin</c>,
        /// <c>nz_ird</c>, <c>pa_ruc</c>, <c>pe_dni</c>, <c>ph_tin</c>, <c>pk_cnic</c>,
        /// <c>pk_snic</c>, <c>pl_pesel</c>, <c>pt_nif</c>, <c>py_ruc</c>, <c>ro_cnp</c>,
        /// <c>sa_tin</c>, <c>se_pin</c>, <c>sg_fin</c>, <c>sg_nric</c>, <c>si_pin</c>,
        /// <c>sk_dic</c>, <c>sv_nit</c>, <c>th_lc</c>, <c>th_pin</c>, <c>tr_tin</c>,
        /// <c>us_itin</c>, <c>us_itin_last_4</c>, <c>us_ssn</c>, <c>us_ssn_last_4</c>,
        /// <c>uy_dni</c>, <c>vg_pp</c>, or <c>za_id</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// The value of the ID number.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
