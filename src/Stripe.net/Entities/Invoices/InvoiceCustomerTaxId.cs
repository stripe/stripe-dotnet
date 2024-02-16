// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceCustomerTaxId : StripeEntity<InvoiceCustomerTaxId>
    {
        /// <summary>
        /// The type of the tax ID, one of <c>ad_nrt</c>, <c>ar_cuit</c>, <c>eu_vat</c>,
        /// <c>bo_tin</c>, <c>br_cnpj</c>, <c>br_cpf</c>, <c>cn_tin</c>, <c>co_nit</c>,
        /// <c>cr_tin</c>, <c>do_rcn</c>, <c>ec_ruc</c>, <c>eu_oss_vat</c>, <c>pe_ruc</c>,
        /// <c>ro_tin</c>, <c>rs_pib</c>, <c>sv_nit</c>, <c>uy_ruc</c>, <c>ve_rif</c>,
        /// <c>vn_tin</c>, <c>gb_vat</c>, <c>nz_gst</c>, <c>au_abn</c>, <c>au_arn</c>,
        /// <c>in_gst</c>, <c>no_vat</c>, <c>no_voec</c>, <c>za_vat</c>, <c>ch_vat</c>,
        /// <c>mx_rfc</c>, <c>sg_uen</c>, <c>ru_inn</c>, <c>ru_kpp</c>, <c>ca_bn</c>, <c>hk_br</c>,
        /// <c>es_cif</c>, <c>tw_vat</c>, <c>th_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>, <c>jp_trn</c>,
        /// <c>li_uid</c>, <c>my_itn</c>, <c>us_ein</c>, <c>kr_brn</c>, <c>ca_qst</c>,
        /// <c>ca_gst_hst</c>, <c>ca_pst_bc</c>, <c>ca_pst_mb</c>, <c>ca_pst_sk</c>, <c>my_sst</c>,
        /// <c>sg_gst</c>, <c>ae_trn</c>, <c>cl_tin</c>, <c>sa_vat</c>, <c>id_npwp</c>,
        /// <c>my_frp</c>, <c>il_vat</c>, <c>ge_vat</c>, <c>ua_vat</c>, <c>is_vat</c>,
        /// <c>bg_uic</c>, <c>hu_tin</c>, <c>si_tin</c>, <c>ke_pin</c>, <c>tr_tin</c>,
        /// <c>eg_tin</c>, <c>ph_tin</c>, or <c>unknown</c>.
        /// One of: <c>ad_nrt</c>, <c>ae_trn</c>, <c>ar_cuit</c>, <c>au_abn</c>, <c>au_arn</c>,
        /// <c>bg_uic</c>, <c>bo_tin</c>, <c>br_cnpj</c>, <c>br_cpf</c>, <c>ca_bn</c>,
        /// <c>ca_gst_hst</c>, <c>ca_pst_bc</c>, <c>ca_pst_mb</c>, <c>ca_pst_sk</c>, <c>ca_qst</c>,
        /// <c>ch_vat</c>, <c>cl_tin</c>, <c>cn_tin</c>, <c>co_nit</c>, <c>cr_tin</c>,
        /// <c>do_rcn</c>, <c>ec_ruc</c>, <c>eg_tin</c>, <c>es_cif</c>, <c>eu_oss_vat</c>,
        /// <c>eu_vat</c>, <c>gb_vat</c>, <c>ge_vat</c>, <c>hk_br</c>, <c>hu_tin</c>,
        /// <c>id_npwp</c>, <c>il_vat</c>, <c>in_gst</c>, <c>is_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>,
        /// <c>jp_trn</c>, <c>ke_pin</c>, <c>kr_brn</c>, <c>li_uid</c>, <c>mx_rfc</c>,
        /// <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>, <c>no_vat</c>, <c>no_voec</c>,
        /// <c>nz_gst</c>, <c>pe_ruc</c>, <c>ph_tin</c>, <c>ro_tin</c>, <c>rs_pib</c>,
        /// <c>ru_inn</c>, <c>ru_kpp</c>, <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>,
        /// <c>si_tin</c>, <c>sv_nit</c>, <c>th_vat</c>, <c>tr_tin</c>, <c>tw_vat</c>,
        /// <c>ua_vat</c>, <c>unknown</c>, <c>us_ein</c>, <c>uy_ruc</c>, <c>ve_rif</c>,
        /// <c>vn_tin</c>, or <c>za_vat</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// The value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
