// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthAuthorizationRateDropResolvedEventDataImpact : StripeEntity<V2CoreHealthAuthorizationRateDropResolvedEventDataImpact>
    {
        /// <summary>
        /// The type of the charge.
        /// One of: <c>money_moving</c>, or <c>validation</c>.
        /// </summary>
        [JsonProperty("charge_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge_type")]
#endif
        public string ChargeType { get; set; }

        /// <summary>
        /// The current authorization rate percentage.
        /// </summary>
        [JsonProperty("current_percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("current_percentage")]
#endif
        public string CurrentPercentage { get; set; }

        /// <summary>
        /// Dimensions that describe what subset of payments are impacted.
        /// </summary>
        [JsonProperty("dimensions")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dimensions")]
#endif
        public List<V2CoreHealthAuthorizationRateDropResolvedEventDataImpactDimension> Dimensions { get; set; }

        /// <summary>
        /// The type of the payment method.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>apple_pay</c>, <c>au_becs_debit</c>,
        /// <c>bacs_debit</c>, <c>bancontact</c>, <c>billie</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>card</c>, <c>card_present</c>, <c>cartes_bancaires</c>, <c>cashapp</c>,
        /// <c>crypto</c>, <c>dummy_passthrough_card</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>,
        /// <c>grabpay</c>, <c>ideal</c>, <c>interac_present</c>, <c>kakao_pay</c>, <c>klarna</c>,
        /// <c>konbini</c>, <c>kriya</c>, <c>kr_card</c>, <c>link</c>, <c>mb_way</c>,
        /// <c>mobilepay</c>, <c>mondu</c>, <c>multibanco</c>, <c>naver_pay</c>, <c>ng_bank</c>,
        /// <c>ng_bank_transfer</c>, <c>ng_card</c>, <c>ng_market</c>, <c>ng_ussd</c>,
        /// <c>ng_wallet</c>, <c>oxxo</c>, <c>p24</c>, <c>paper_check</c>, <c>payco</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>paypay</c>, <c>payto</c>, <c>pay_by_bank</c>,
        /// <c>pix</c>, <c>promptpay</c>, <c>rechnung</c>, <c>revolut_pay</c>, <c>samsung_pay</c>,
        /// <c>satispay</c>, <c>scalapay</c>, <c>sepa_debit</c>, <c>sequra</c>, <c>sofort</c>,
        /// <c>sunbit</c>, <c>swish</c>, <c>twint</c>, <c>upi</c>, <c>us_bank_account</c>,
        /// <c>vipps</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("payment_method_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_type")]
#endif
        public string PaymentMethodType { get; set; }

        /// <summary>
        /// The previous authorization rate percentage.
        /// </summary>
        [JsonProperty("previous_percentage")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("previous_percentage")]
#endif
        public string PreviousPercentage { get; set; }
    }
}
