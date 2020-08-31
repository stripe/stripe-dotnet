namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxIdCreateOptions : BaseOptions
    {
        /// <summary>
        /// Type of the tax ID, one of <c>ae_trn</c>, <c>au_abn</c>, <c>br_cnpj</c>, <c>br_cpf</c>,
        /// <c>ca_bn</c>, <c>ca_qst</c>, <c>ch_vat</c>, <c>cl_tin</c>, <c>es_cif</c>, <c>eu_vat</c>,
        /// <c>hk_br</c>, <c>id_npwp</c>, <c>in_gst</c>, <c>jp_cn</c>, <c>kr_brn</c>, <c>li_uid</c>,
        /// <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>, <c>no_vat</c>,
        /// <c>nz_gst</c>, <c>ru_inn</c>, <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>,
        /// <c>th_vat</c>, <c>tw_vat</c>, <c>us_ein</c>, or <c>za_vat</c>.
        /// One of: <c>ae_trn</c>, <c>au_abn</c>, <c>br_cnpj</c>, <c>br_cpf</c>, <c>ca_bn</c>,
        /// <c>ca_qst</c>, <c>ch_vat</c>, <c>cl_tin</c>, <c>es_cif</c>, <c>eu_vat</c>, <c>hk_br</c>,
        /// <c>id_npwp</c>, <c>in_gst</c>, <c>jp_cn</c>, <c>kr_brn</c>, <c>li_uid</c>,
        /// <c>mx_rfc</c>, <c>my_frp</c>, <c>my_itn</c>, <c>my_sst</c>, <c>no_vat</c>,
        /// <c>nz_gst</c>, <c>ru_inn</c>, <c>sa_vat</c>, <c>sg_gst</c>, <c>sg_uen</c>,
        /// <c>th_vat</c>, <c>tw_vat</c>, <c>us_ein</c>, or <c>za_vat</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Value of the tax ID.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
