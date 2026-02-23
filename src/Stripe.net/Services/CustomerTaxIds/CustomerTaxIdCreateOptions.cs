// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerTaxIdCreateOptions : BaseOptions
    {
        /// <summary>
        /// Type of the tax ID, one of <c>ad_nrt</c>, <c>ae_trn</c>, <c>al_tin</c>, <c>am_tin</c>,
        /// <c>ao_tin</c>, <c>ar_cuit</c>, <c>au_abn</c>, <c>au_arn</c>, <c>aw_tin</c>,
        /// <c>az_tin</c>, <c>ba_tin</c>, <c>bb_tin</c>, <c>bd_bin</c>, <c>bf_ifu</c>,
        /// <c>bg_uic</c>, <c>bh_vat</c>, <c>bj_ifu</c>, <c>bo_tin</c>, <c>br_cnpj</c>,
        /// <c>br_cpf</c>, <c>bs_tin</c>, <c>by_tin</c>, <c>ca_bn</c>, <c>ca_gst_hst</c>,
        /// <c>ca_pst_bc</c>, <c>ca_pst_mb</c>, <c>ca_pst_sk</c>, <c>ca_qst</c>, <c>cd_nif</c>,
        /// <c>ch_uid</c>, <c>ch_vat</c>, <c>cl_tin</c>, <c>cm_niu</c>, <c>cn_tin</c>,
        /// <c>co_nit</c>, <c>cr_tin</c>, <c>cv_nif</c>, <c>de_stn</c>, <c>do_rcn</c>,
        /// <c>ec_ruc</c>, <c>eg_tin</c>, <c>es_cif</c>, <c>et_tin</c>, <c>eu_oss_vat</c>,
        /// <c>eu_vat</c>, <c>gb_vat</c>, <c>ge_vat</c>, <c>gn_nif</c>, <c>hk_br</c>, <c>hr_oib</c>,
        /// <c>hu_tin</c>, <c>id_npwp</c>, <c>il_vat</c>, <c>in_gst</c>, <c>is_vat</c>,
        /// <c>jp_cn</c>, <c>jp_rn</c>, <c>jp_trn</c>, <c>ke_pin</c>, <c>kg_tin</c>, <c>kh_tin</c>,
        /// <c>kr_brn</c>, <c>kz_bin</c>, <c>la_tin</c>, <c>li_uid</c>, <c>li_vat</c>,
        /// <c>lk_vat</c>, <c>ma_vat</c>, <c>md_vat</c>, <c>me_pib</c>, <c>mk_vat</c>,
        /// <c>mr_nif</c>, <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>,
        /// <c>ng_tin</c>, <c>no_vat</c>, <c>no_voec</c>, <c>np_pan</c>, <c>nz_gst</c>,
        /// <c>om_vat</c>, <c>pe_ruc</c>, <c>ph_tin</c>, <c>pl_nip</c>, <c>ro_tin</c>,
        /// <c>rs_pib</c>, <c>ru_inn</c>, <c>ru_kpp</c>, <c>sa_vat</c>, <c>sg_gst</c>,
        /// <c>sg_uen</c>, <c>si_tin</c>, <c>sn_ninea</c>, <c>sr_fin</c>, <c>sv_nit</c>,
        /// <c>th_vat</c>, <c>tj_tin</c>, <c>tr_tin</c>, <c>tw_vat</c>, <c>tz_vat</c>,
        /// <c>ua_vat</c>, <c>ug_tin</c>, <c>us_ein</c>, <c>uy_ruc</c>, <c>uz_tin</c>,
        /// <c>uz_vat</c>, <c>ve_rif</c>, <c>vn_tin</c>, <c>za_vat</c>, <c>zm_tin</c>, or
        /// <c>zw_tin</c>.
        /// One of: <c>ad_nrt</c>, <c>ae_trn</c>, <c>al_tin</c>, <c>am_tin</c>, <c>ao_tin</c>,
        /// <c>ar_cuit</c>, <c>au_abn</c>, <c>au_arn</c>, <c>aw_tin</c>, <c>az_tin</c>,
        /// <c>ba_tin</c>, <c>bb_tin</c>, <c>bd_bin</c>, <c>bf_ifu</c>, <c>bg_uic</c>,
        /// <c>bh_vat</c>, <c>bj_ifu</c>, <c>bo_tin</c>, <c>br_cnpj</c>, <c>br_cpf</c>,
        /// <c>bs_tin</c>, <c>by_tin</c>, <c>ca_bn</c>, <c>ca_gst_hst</c>, <c>ca_pst_bc</c>,
        /// <c>ca_pst_mb</c>, <c>ca_pst_sk</c>, <c>ca_qst</c>, <c>cd_nif</c>, <c>ch_uid</c>,
        /// <c>ch_vat</c>, <c>cl_tin</c>, <c>cm_niu</c>, <c>cn_tin</c>, <c>co_nit</c>,
        /// <c>cr_tin</c>, <c>cv_nif</c>, <c>de_stn</c>, <c>do_rcn</c>, <c>ec_ruc</c>,
        /// <c>eg_tin</c>, <c>es_cif</c>, <c>et_tin</c>, <c>eu_oss_vat</c>, <c>eu_vat</c>,
        /// <c>gb_vat</c>, <c>ge_vat</c>, <c>gn_nif</c>, <c>hk_br</c>, <c>hr_oib</c>, <c>hu_tin</c>,
        /// <c>id_npwp</c>, <c>il_vat</c>, <c>in_gst</c>, <c>is_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>,
        /// <c>jp_trn</c>, <c>ke_pin</c>, <c>kg_tin</c>, <c>kh_tin</c>, <c>kr_brn</c>,
        /// <c>kz_bin</c>, <c>la_tin</c>, <c>li_uid</c>, <c>li_vat</c>, <c>lk_vat</c>,
        /// <c>ma_vat</c>, <c>md_vat</c>, <c>me_pib</c>, <c>mk_vat</c>, <c>mr_nif</c>,
        /// <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>, <c>ng_tin</c>,
        /// <c>no_vat</c>, <c>no_voec</c>, <c>np_pan</c>, <c>nz_gst</c>, <c>om_vat</c>,
        /// <c>pe_ruc</c>, <c>ph_tin</c>, <c>pl_nip</c>, <c>ro_tin</c>, <c>rs_pib</c>,
        /// <c>ru_inn</c>, <c>ru_kpp</c>, <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>,
        /// <c>si_tin</c>, <c>sn_ninea</c>, <c>sr_fin</c>, <c>sv_nit</c>, <c>th_vat</c>,
        /// <c>tj_tin</c>, <c>tr_tin</c>, <c>tw_vat</c>, <c>tz_vat</c>, <c>ua_vat</c>,
        /// <c>ug_tin</c>, <c>us_ein</c>, <c>uy_ruc</c>, <c>uz_tin</c>, <c>uz_vat</c>,
        /// <c>ve_rif</c>, <c>vn_tin</c>, <c>za_vat</c>, <c>zm_tin</c>, or <c>zw_tin</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// Value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
