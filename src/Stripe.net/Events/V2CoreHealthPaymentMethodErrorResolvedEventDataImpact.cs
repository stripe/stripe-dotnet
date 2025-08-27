// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class V2CoreHealthPaymentMethodErrorResolvedEventDataImpact : StripeEntity<V2CoreHealthPaymentMethodErrorResolvedEventDataImpact>
    {
        /// <summary>
        /// The returned error code.
        /// </summary>
        [JsonProperty("error_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("error_code")]
#endif
        public string ErrorCode { get; set; }

        /// <summary>
        /// The number of impacted requests.
        /// </summary>
        [JsonProperty("impacted_requests")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("impacted_requests")]
#endif
        public long ImpactedRequests { get; set; }

        /// <summary>
        /// The type of the payment method.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>apple_pay</c>, <c>au_becs_debit</c>,
        /// <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>card_present</c>, <c>cartes_bancaires</c>, <c>cashapp</c>,
        /// <c>dummy_passthrough_card</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>,
        /// <c>ideal</c>, <c>interac_present</c>, <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>,
        /// <c>link</c>, <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>, <c>oxxo</c>,
        /// <c>p24</c>, <c>paper_check</c>, <c>paynow</c>, <c>paypal</c>, <c>payto</c>,
        /// <c>pay_by_bank</c>, <c>pix</c>, <c>promptpay</c>, <c>revolut_pay</c>, <c>sepa_debit</c>,
        /// <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>upi</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("payment_method_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method_type")]
#endif
        public string PaymentMethodType { get; set; }
    }
}
