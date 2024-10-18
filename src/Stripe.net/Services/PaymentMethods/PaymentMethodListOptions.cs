// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the customer whose PaymentMethods will be retrieved.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// An optional filter on the list, based on the object <c>type</c> field. Without the
        /// filter, the list includes all current and future payment method types. If your
        /// integration expects only one type of payment method in the response, make sure to
        /// provide a type value in the request.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>alma</c>, <c>amazon_pay</c>, <c>au_becs_debit</c>, <c>bacs_debit</c>,
        /// <c>bancontact</c>, <c>blik</c>, <c>boleto</c>, <c>card</c>, <c>cashapp</c>,
        /// <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>, <c>gopay</c>,
        /// <c>grabpay</c>, <c>ideal</c>, <c>kakao_pay</c>, <c>klarna</c>, <c>konbini</c>,
        /// <c>kr_card</c>, <c>link</c>, <c>mb_way</c>, <c>mobilepay</c>, <c>multibanco</c>,
        /// <c>naver_pay</c>, <c>oxxo</c>, <c>p24</c>, <c>payco</c>, <c>paynow</c>, <c>paypal</c>,
        /// <c>payto</c>, <c>pix</c>, <c>promptpay</c>, <c>qris</c>, <c>rechnung</c>,
        /// <c>revolut_pay</c>, <c>samsung_pay</c>, <c>sepa_debit</c>, <c>shopeepay</c>,
        /// <c>sofort</c>, <c>swish</c>, <c>twint</c>, <c>us_bank_account</c>, <c>wechat_pay</c>, or
        /// <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
