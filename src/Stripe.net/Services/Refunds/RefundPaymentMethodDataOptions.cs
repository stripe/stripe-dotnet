// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RefundPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// The gift card to receive the refund.
        /// </summary>
        [JsonProperty("gift_card")]
        [STJS.JsonPropertyName("gift_card")]
        public RefundPaymentMethodDataGiftCardOptions GiftCard { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>billie</c>, <c>bizum</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>,
        /// <c>carecredit</c>, <c>cashapp</c>, <c>crypto</c>, <c>custom</c>,
        /// <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>getflex</c>, <c>gift_card</c>,
        /// <c>giropay</c>, <c>gopay</c>, <c>grabpay</c>, <c>id_bank_transfer</c>, <c>ideal</c>,
        /// <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>, <c>kr_card</c>, <c>link</c>,
        /// <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>, <c>naver_pay</c>,
        /// <c>nz_bank_account</c>, <c>oxxo</c>, <c>p24</c>, <c>pay_by_bank</c>, <c>payco</c>,
        /// <c>paynow</c>, <c>paypal</c>, <c>paypay</c>, <c>payto</c>, <c>pix</c>, <c>promptpay</c>,
        /// <c>qris</c>, <c>rakuten_pay</c>, <c>rechnung</c>, <c>revolut_pay</c>,
        /// <c>samsung_pay</c>, <c>satispay</c>, <c>scalapay</c>, <c>sepa_debit</c>, <c>sequra</c>,
        /// <c>sezzle</c>, <c>shopeepay</c>, <c>sofort</c>, <c>stripe_balance</c>, <c>sunbit</c>,
        /// <c>swish</c>, <c>tamara</c>, <c>toss_pay</c>, <c>twint</c>, <c>upi</c>,
        /// <c>us_bank_account</c>, <c>vipps</c>, <c>wechat_pay</c>, <c>wero</c>, or <c>zip</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
