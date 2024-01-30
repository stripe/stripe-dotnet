// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// contains details about the Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
        public SessionPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// contains details about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        public SessionPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// contains details about the Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        public SessionPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// contains details about the AU Becs Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public SessionPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// contains details about the Bacs Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public SessionPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// contains details about the Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        public SessionPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// contains details about the Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
        public SessionPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// contains details about the Card payment method options.
        /// </summary>
        [JsonProperty("card")]
        public SessionPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// contains details about the Cashapp Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
        public SessionPaymentMethodOptionsCashappOptions Cashapp { get; set; }

        /// <summary>
        /// contains details about the Customer Balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
        public SessionPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// contains details about the EPS payment method options.
        /// </summary>
        [JsonProperty("eps")]
        public SessionPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// contains details about the FPX payment method options.
        /// </summary>
        [JsonProperty("fpx")]
        public SessionPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// contains details about the Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
        public SessionPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// contains details about the Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
        public SessionPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// contains details about the Ideal payment method options.
        /// </summary>
        [JsonProperty("ideal")]
        public SessionPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// contains details about the Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
        public SessionPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// contains details about the Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        public SessionPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// contains details about the Link payment method options.
        /// </summary>
        [JsonProperty("link")]
        public SessionPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// contains details about the OXXO payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
        public SessionPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// contains details about the P24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
        public SessionPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// contains details about the PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
        public SessionPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// contains details about the PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
        public SessionPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// contains details about the Pix payment method options.
        /// </summary>
        [JsonProperty("pix")]
        public SessionPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// contains details about the RevolutPay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
        public SessionPaymentMethodOptionsRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// contains details about the Sepa Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public SessionPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// contains details about the Sofort payment method options.
        /// </summary>
        [JsonProperty("sofort")]
        public SessionPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// contains details about the Swish payment method options.
        /// </summary>
        [JsonProperty("swish")]
        public SessionPaymentMethodOptionsSwishOptions Swish { get; set; }

        /// <summary>
        /// contains details about the Us Bank Account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public SessionPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// contains details about the WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public SessionPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }
    }
}
