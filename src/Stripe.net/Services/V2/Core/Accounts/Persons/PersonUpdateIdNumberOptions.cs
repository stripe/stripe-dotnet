// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonUpdateIdNumberOptions : INestedOptions
    {
        /// <summary>
        /// The ID number type of an individual.
        /// One of: <c>ae_eid</c>, <c>ae_pp</c>, <c>al_pp</c>, <c>am_pp</c>, <c>ao_nif</c>,
        /// <c>ar_cuil</c>, <c>ar_dni</c>, <c>ar_pp</c>, <c>at_pp</c>, <c>at_stn</c>, <c>au_pp</c>,
        /// <c>az_pin</c>, <c>az_pp</c>, <c>az_tin</c>, <c>bd_brc</c>, <c>bd_etin</c>,
        /// <c>bd_nid</c>, <c>bd_pp</c>, <c>be_nrn</c>, <c>be_pp</c>, <c>bg_pp</c>, <c>bg_ucn</c>,
        /// <c>bh_pp</c>, <c>bj_pp</c>, <c>bn_nric</c>, <c>bo_pp</c>, <c>br_cpf</c>, <c>br_pp</c>,
        /// <c>br_rg</c>, <c>bs_pp</c>, <c>bs_tin</c>, <c>by_pp</c>, <c>ca_pp</c>, <c>ca_sin</c>,
        /// <c>ch_oasi</c>, <c>ch_pp</c>, <c>ci_pp</c>, <c>cl_pp</c>, <c>cl_rut</c>, <c>cm_pp</c>,
        /// <c>cn_pp</c>, <c>co_nuip</c>, <c>co_pp</c>, <c>cr_ci</c>, <c>cr_cpf</c>,
        /// <c>cr_dimex</c>, <c>cr_nite</c>, <c>cr_pp</c>, <c>cy_pp</c>, <c>cy_tic</c>,
        /// <c>cz_dic</c>, <c>cz_pp</c>, <c>cz_rc</c>, <c>de_pp</c>, <c>de_stn</c>, <c>dk_cpr</c>,
        /// <c>dk_pp</c>, <c>do_cie</c>, <c>do_pp</c>, <c>do_rcn</c>, <c>dz_pp</c>, <c>ec_ci</c>,
        /// <c>ec_pp</c>, <c>ee_ik</c>, <c>ee_pp</c>, <c>eg_pp</c>, <c>es_nif</c>, <c>es_pp</c>,
        /// <c>et_tin</c>, <c>fi_hetu</c>, <c>fi_pp</c>, <c>fr_nir</c>, <c>fr_pp</c>, <c>fr_spi</c>,
        /// <c>ga_nif</c>, <c>gb_nino</c>, <c>gb_pp</c>, <c>ge_pp</c>, <c>gh_pp</c>, <c>gr_afm</c>,
        /// <c>gr_pp</c>, <c>gt_cui</c>, <c>gt_nit</c>, <c>gt_pp</c>, <c>hk_id</c>, <c>hk_pp</c>,
        /// <c>hn_dni</c>, <c>hn_pp</c>, <c>hr_oib</c>, <c>hr_pp</c>, <c>ht_pp</c>, <c>hu_ad</c>,
        /// <c>hu_pp</c>, <c>id_nik</c>, <c>id_pp</c>, <c>ie_pp</c>, <c>ie_ppsn</c>, <c>il_pp</c>,
        /// <c>in_pan</c>, <c>in_pp</c>, <c>iq_pp</c>, <c>is_kt</c>, <c>is_pp</c>, <c>it_cf</c>,
        /// <c>it_pp</c>, <c>je_pp</c>, <c>jm_pp</c>, <c>jo_pp</c>, <c>jp_inc</c>, <c>jp_pp</c>,
        /// <c>ke_pin</c>, <c>ke_pp</c>, <c>kr_pp</c>, <c>kw_pp</c>, <c>kz_iin</c>, <c>kz_pp</c>,
        /// <c>lb_pp</c>, <c>li_peid</c>, <c>li_pp</c>, <c>lk_pp</c>, <c>lt_ak</c>, <c>lt_pp</c>,
        /// <c>lu_nif</c>, <c>lu_pp</c>, <c>lv_pk</c>, <c>lv_pp</c>, <c>ma_pp</c>, <c>md_cf</c>,
        /// <c>md_pp</c>, <c>mg_nif</c>, <c>mk_pin</c>, <c>mk_pp</c>, <c>mm_pp</c>, <c>mn_pp</c>,
        /// <c>mt_pp</c>, <c>mu_pp</c>, <c>mx_curp</c>, <c>mx_pp</c>, <c>mx_rfc</c>, <c>my_nric</c>,
        /// <c>my_pp</c>, <c>mz_nuit</c>, <c>ng_nin</c>, <c>ng_pp</c>, <c>nl_bsn</c>, <c>nl_pp</c>,
        /// <c>no_nin</c>, <c>no_pp</c>, <c>np_pp</c>, <c>nz_ird</c>, <c>nz_pp</c>, <c>pa_pp</c>,
        /// <c>pe_dni</c>, <c>pe_pp</c>, <c>ph_pp</c>, <c>pk_cnic</c>, <c>pk_pp</c>, <c>pk_snic</c>,
        /// <c>pl_pesel</c>, <c>pl_pp</c>, <c>pr_pp</c>, <c>ps_pp</c>, <c>pt_nif</c>, <c>pt_pp</c>,
        /// <c>py_ci</c>, <c>py_pp</c>, <c>ro_cnp</c>, <c>ro_pp</c>, <c>rs_pp</c>, <c>ru_pp</c>,
        /// <c>rw_tin</c>, <c>sa_pp</c>, <c>sa_ptin</c>, <c>sa_tin</c>, <c>se_pin</c>, <c>se_pp</c>,
        /// <c>sg_fin</c>, <c>sg_nric</c>, <c>sg_pp</c>, <c>si_pp</c>, <c>si_ptin</c>,
        /// <c>sk_dic</c>, <c>sk_pp</c>, <c>sv_pp</c>, <c>th_lc</c>, <c>th_pin</c>, <c>th_pp</c>,
        /// <c>tn_pp</c>, <c>tr_pp</c>, <c>tr_tin</c>, <c>tt_bir</c>, <c>tw_pp</c>, <c>ua_pp</c>,
        /// <c>ug_pp</c>, <c>us_itin</c>, <c>us_itin_last_4</c>, <c>us_pp</c>, <c>us_ssn</c>,
        /// <c>us_ssn_last_4</c>, <c>uy_dni</c>, <c>uy_pp</c>, <c>uz_pp</c>, <c>uz_tin</c>,
        /// <c>ve_pp</c>, <c>vn_pp</c>, <c>za_id</c>, or <c>za_pp</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
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
