// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationRecipientDefaultOutboundDestination : StripeEntity<AccountConfigurationRecipientDefaultOutboundDestination>
    {
        /// <summary>
        /// Closed Enum. The payout method type of the default outbound destination.
        /// One of: <c>at_bank_account</c>, <c>au_bank_account</c>, <c>ba_bank_account</c>,
        /// <c>be_bank_account</c>, <c>bg_bank_account</c>, <c>bj_bank_account</c>,
        /// <c>bs_bank_account</c>, <c>card</c>, <c>ca_bank_account</c>, <c>ch_bank_account</c>,
        /// <c>ci_bank_account</c>, <c>cy_bank_account</c>, <c>cz_bank_account</c>,
        /// <c>de_bank_account</c>, <c>dk_bank_account</c>, <c>ec_bank_account</c>,
        /// <c>ee_bank_account</c>, <c>es_bank_account</c>, <c>et_bank_account</c>,
        /// <c>fi_bank_account</c>, <c>fr_bank_account</c>, <c>gb_bank_account</c>,
        /// <c>gr_bank_account</c>, <c>hr_bank_account</c>, <c>hu_bank_account</c>,
        /// <c>id_bank_account</c>, <c>ie_bank_account</c>, <c>il_bank_account</c>,
        /// <c>in_bank_account</c>, <c>is_bank_account</c>, <c>it_bank_account</c>,
        /// <c>ke_bank_account</c>, <c>li_bank_account</c>, <c>lt_bank_account</c>,
        /// <c>lu_bank_account</c>, <c>lv_bank_account</c>, <c>mn_bank_account</c>,
        /// <c>mt_bank_account</c>, <c>mu_bank_account</c>, <c>mx_bank_account</c>,
        /// <c>na_bank_account</c>, <c>nl_bank_account</c>, <c>no_bank_account</c>,
        /// <c>nz_bank_account</c>, <c>pa_bank_account</c>, <c>ph_bank_account</c>,
        /// <c>pl_bank_account</c>, <c>pt_bank_account</c>, <c>ro_bank_account</c>,
        /// <c>rs_bank_account</c>, <c>se_bank_account</c>, <c>sg_bank_account</c>,
        /// <c>si_bank_account</c>, <c>sk_bank_account</c>, <c>sn_bank_account</c>,
        /// <c>sv_bank_account</c>, <c>tn_bank_account</c>, <c>tr_bank_account</c>,
        /// <c>us_bank_account</c>, or <c>za_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
