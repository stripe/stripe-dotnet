// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCustomerDetailsTaxId : StripeEntity<SessionCustomerDetailsTaxId>
    {
        /// <summary>
        /// The type of the tax ID, one of <c>eu_vat</c>, <c>br_cnpj</c>, <c>br_cpf</c>,
        /// <c>eu_oss_vat</c>, <c>gb_vat</c>, <c>nz_gst</c>, <c>au_abn</c>, <c>au_arn</c>,
        /// <c>in_gst</c>, <c>no_vat</c>, <c>za_vat</c>, <c>ch_vat</c>, <c>mx_rfc</c>,
        /// <c>sg_uen</c>, <c>ru_inn</c>, <c>ru_kpp</c>, <c>ca_bn</c>, <c>hk_br</c>, <c>es_cif</c>,
        /// <c>tw_vat</c>, <c>th_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>, <c>jp_trn</c>, <c>li_uid</c>,
        /// <c>my_itn</c>, <c>us_ein</c>, <c>kr_brn</c>, <c>ca_qst</c>, <c>ca_gst_hst</c>,
        /// <c>ca_pst_bc</c>, <c>ca_pst_mb</c>, <c>ca_pst_sk</c>, <c>my_sst</c>, <c>sg_gst</c>,
        /// <c>ae_trn</c>, <c>cl_tin</c>, <c>sa_vat</c>, <c>id_npwp</c>, <c>my_frp</c>,
        /// <c>il_vat</c>, <c>ge_vat</c>, <c>ua_vat</c>, <c>is_vat</c>, <c>bg_uic</c>,
        /// <c>hu_tin</c>, <c>si_tin</c>, <c>ke_pin</c>, <c>tr_tin</c>, <c>eg_tin</c>,
        /// <c>ph_tin</c>, or <c>unknown</c>.
        /// One of: <c>ae_trn</c>, <c>au_abn</c>, <c>au_arn</c>, <c>bg_uic</c>, <c>br_cnpj</c>,
        /// <c>br_cpf</c>, <c>ca_bn</c>, <c>ca_gst_hst</c>, <c>ca_pst_bc</c>, <c>ca_pst_mb</c>,
        /// <c>ca_pst_sk</c>, <c>ca_qst</c>, <c>ch_vat</c>, <c>cl_tin</c>, <c>eg_tin</c>,
        /// <c>es_cif</c>, <c>eu_oss_vat</c>, <c>eu_vat</c>, <c>gb_vat</c>, <c>ge_vat</c>,
        /// <c>hk_br</c>, <c>hu_tin</c>, <c>id_npwp</c>, <c>il_vat</c>, <c>in_gst</c>,
        /// <c>is_vat</c>, <c>jp_cn</c>, <c>jp_rn</c>, <c>jp_trn</c>, <c>ke_pin</c>, <c>kr_brn</c>,
        /// <c>li_uid</c>, <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>,
        /// <c>no_vat</c>, <c>nz_gst</c>, <c>ph_tin</c>, <c>ru_inn</c>, <c>ru_kpp</c>,
        /// <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>, <c>si_tin</c>, <c>th_vat</c>,
        /// <c>tr_tin</c>, <c>tw_vat</c>, <c>ua_vat</c>, <c>unknown</c>, <c>us_ein</c>, or
        /// <c>za_vat</c>.
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
