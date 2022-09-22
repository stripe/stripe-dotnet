// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the ACSS Debit
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If paying by <c>afterpay_clearpay</c>, this sub-hash contains details about the
        /// AfterpayClearpay payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        public OrderPaymentSettingsPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If paying by <c>alipay</c>, this sub-hash contains details about the Alipay payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("alipay")]
        public OrderPaymentSettingsPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public OrderPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public OrderPaymentSettingsPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If paying by <c>customer_balance</c>, this sub-hash contains details about the Customer
        /// Balance payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance")]
        public OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If paying by <c>ideal</c>, this sub-hash contains details about the iDEAL payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("ideal")]
        public OrderPaymentSettingsPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// If paying by <c>klarna</c>, this sub-hash contains details about the Klarna payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("klarna")]
        public OrderPaymentSettingsPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If paying by <c>link</c>, this sub-hash contains details about the Link payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("link")]
        public OrderPaymentSettingsPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If paying by <c>oxxo</c>, this sub-hash contains details about the OXXO payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("oxxo")]
        public OrderPaymentSettingsPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If paying by <c>p24</c>, this sub-hash contains details about the P24 payment method
        /// options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("p24")]
        public OrderPaymentSettingsPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// If paying by <c>paypal</c>, this sub-hash contains details about the PayPal payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("paypal")]
        public OrderPaymentSettingsPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If paying by <c>sepa_debit</c>, this sub-hash contains details about the SEPA Debit
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public OrderPaymentSettingsPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If paying by <c>sofort</c>, this sub-hash contains details about the Sofort payment
        /// method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("sofort")]
        public OrderPaymentSettingsPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// If paying by <c>wechat_pay</c>, this sub-hash contains details about the WeChat Pay
        /// payment method options to pass to the order's PaymentIntent.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public OrderPaymentSettingsPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }
    }
}
