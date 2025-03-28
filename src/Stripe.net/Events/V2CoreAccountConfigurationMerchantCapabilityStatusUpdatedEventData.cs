// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreAccountConfigurationMerchantCapabilityStatusUpdatedEventData : StripeEntity<V2CoreAccountConfigurationMerchantCapabilityStatusUpdatedEventData>
    {
        /// <summary>
        /// Open Enum. The capability which had its status updated.
        /// One of: <c>ach_debit_payments</c>, <c>acss_debit_payments</c>, <c>affirm_payments</c>,
        /// <c>afterpay_clearpay_payments</c>, <c>alma_payments</c>, <c>amazon_pay_payments</c>,
        /// <c>au_becs_debit_payments</c>, <c>bacs_debit_payments</c>, <c>bancontact_payments</c>,
        /// <c>blik_payments</c>, <c>boleto_payments</c>, <c>card_payments</c>,
        /// <c>cartes_bancaires_payments</c>, <c>cashapp_payments</c>, <c>eps_payments</c>,
        /// <c>fpx_payments</c>, <c>gb_bank_transfer_payments</c>, <c>grabpay_payments</c>,
        /// <c>ideal_payments</c>, <c>jcb_payments</c>, <c>jp_bank_transfer_payments</c>,
        /// <c>kakao_pay_payments</c>, <c>klarna_payments</c>, <c>konbini_payments</c>,
        /// <c>kr_card_payments</c>, <c>link_payments</c>, <c>mobilepay_payments</c>,
        /// <c>multibanco_payments</c>, <c>mx_bank_transfer_payments</c>, <c>naver_pay_payments</c>,
        /// <c>oxxo_payments</c>, <c>p24_payments</c>, <c>payco_payments</c>,
        /// <c>paynow_payments</c>, <c>pay_by_bank_payments</c>, <c>promptpay_payments</c>,
        /// <c>revolut_pay_payments</c>, <c>samsung_pay_payments</c>,
        /// <c>sepa_bank_transfer_payments</c>, <c>sepa_debit_payments</c>, <c>swish_payments</c>,
        /// <c>twint_payments</c>, <c>us_bank_transfer_payments</c>, or <c>zip_payments</c>.
        /// </summary>
        [JsonProperty("updated_capability")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("updated_capability")]
#endif
        public string UpdatedCapability { get; set; }
    }
}
