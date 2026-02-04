// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountTokenCreateIdentityBusinessDetailsIdNumberOptions : INestedOptions
    {
        /// <summary>
        /// The registrar of the ID number (Only valid for DE ID number types).
        /// </summary>
        [JsonProperty("registrar")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registrar")]
#endif
        public string Registrar { get; set; }

        /// <summary>
        /// Open Enum. The ID number type of a business entity.
        /// One of: <c>ae_crn</c>, <c>ae_vat</c>, <c>ao_nif</c>, <c>ar_cuit</c>, <c>at_fn</c>,
        /// <c>at_stn</c>, <c>at_vat</c>, <c>au_abn</c>, <c>au_acn</c>, <c>au_in</c>, <c>az_tin</c>,
        /// <c>bd_etin</c>, <c>be_cbe</c>, <c>be_vat</c>, <c>bg_uic</c>, <c>bg_vat</c>,
        /// <c>br_cnpj</c>, <c>ca_cn</c>, <c>ca_crarr</c>, <c>ca_gst_hst</c>, <c>ca_neq</c>,
        /// <c>ca_rid</c>, <c>ch_chid</c>, <c>ch_uid</c>, <c>cr_cpj</c>, <c>cr_nite</c>,
        /// <c>cy_he</c>, <c>cy_tic</c>, <c>cy_vat</c>, <c>cz_ico</c>, <c>cz_vat</c>, <c>de_hrn</c>,
        /// <c>de_stn</c>, <c>de_vat</c>, <c>dk_cvr</c>, <c>dk_vat</c>, <c>do_rcn</c>, <c>ee_rk</c>,
        /// <c>ee_vat</c>, <c>es_cif</c>, <c>es_vat</c>, <c>fi_vat</c>, <c>fi_yt</c>, <c>fr_rna</c>,
        /// <c>fr_siren</c>, <c>fr_vat</c>, <c>gb_crn</c>, <c>gb_vat</c>, <c>gi_crn</c>,
        /// <c>gr_afm</c>, <c>gr_gemi</c>, <c>gr_vat</c>, <c>gt_nit</c>, <c>hk_br</c>, <c>hk_cr</c>,
        /// <c>hr_mbs</c>, <c>hr_oib</c>, <c>hr_vat</c>, <c>hu_cjs</c>, <c>hu_tin</c>,
        /// <c>hu_vat</c>, <c>ie_crn</c>, <c>ie_trn</c>, <c>ie_vat</c>, <c>it_rea</c>,
        /// <c>it_vat</c>, <c>jp_cn</c>, <c>kz_bin</c>, <c>li_uid</c>, <c>lt_ccrn</c>,
        /// <c>lt_vat</c>, <c>lu_nif</c>, <c>lu_rcs</c>, <c>lu_vat</c>, <c>lv_urn</c>,
        /// <c>lv_vat</c>, <c>mt_crn</c>, <c>mt_tin</c>, <c>mt_vat</c>, <c>mx_rfc</c>,
        /// <c>my_brn</c>, <c>my_coid</c>, <c>my_itn</c>, <c>my_sst</c>, <c>mz_nuit</c>,
        /// <c>nl_kvk</c>, <c>nl_rsin</c>, <c>nl_vat</c>, <c>no_orgnr</c>, <c>nz_bn</c>,
        /// <c>nz_ird</c>, <c>pe_ruc</c>, <c>pk_ntn</c>, <c>pl_nip</c>, <c>pl_regon</c>,
        /// <c>pl_vat</c>, <c>pt_vat</c>, <c>ro_cui</c>, <c>ro_orc</c>, <c>ro_vat</c>,
        /// <c>sa_crn</c>, <c>sa_tin</c>, <c>se_orgnr</c>, <c>se_vat</c>, <c>sg_uen</c>,
        /// <c>si_msp</c>, <c>si_tin</c>, <c>si_vat</c>, <c>sk_dic</c>, <c>sk_ico</c>,
        /// <c>sk_vat</c>, <c>th_crn</c>, <c>th_prn</c>, <c>th_tin</c>, or <c>us_ein</c>.
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
