// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>acss_debit</c> PaymentMethod, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        public PaymentIntentPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this sub-hash contains details about the
        /// Affirm payment method options.
        /// </summary>
        [JsonProperty("affirm")]
        public PaymentIntentPaymentMethodOptionsAffirmOptions Affirm { get; set; }

        /// <summary>
        /// If this is a <c>afterpay_clearpay</c> PaymentMethod, this sub-hash contains details
        /// about the Afterpay Clearpay payment method options.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        public PaymentIntentPaymentMethodOptionsAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If this is a <c>alipay</c> PaymentMethod, this sub-hash contains details about the
        /// Alipay payment method options.
        /// </summary>
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodOptionsAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is a <c>au_becs_debit</c> PaymentMethod, this sub-hash contains details about
        /// the AU BECS Direct Debit payment method options.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentIntentPaymentMethodOptionsAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this sub-hash contains details about the
        /// BACS Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public PaymentIntentPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this sub-hash contains details about the
        /// Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this sub-hash contains details about the BLIK
        /// payment method options.
        /// </summary>
        [JsonProperty("blik")]
        public PaymentIntentPaymentMethodOptionsBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this sub-hash contains details about the
        /// Boleto payment method options.
        /// </summary>
        [JsonProperty("boleto")]
        public PaymentIntentPaymentMethodOptionsBoletoOptions Boleto { get; set; }

        /// <summary>
        /// Configuration for any card payments attempted on this PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>card_present</c> PaymentMethod, this sub-hash contains details about the
        /// Card Present payment method options.
        /// </summary>
        [JsonProperty("card_present")]
        public PaymentIntentPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// If this is a <c>cashapp</c> PaymentMethod, this sub-hash contains details about the Cash
        /// App Pay payment method options.
        /// </summary>
        [JsonProperty("cashapp")]
        public PaymentIntentPaymentMethodOptionsCashappOptions Cashapp { get; set; }

        /// <summary>
        /// If this is a <c>customer balance</c> PaymentMethod, this sub-hash contains details about
        /// the customer balance payment method options.
        /// </summary>
        [JsonProperty("customer_balance")]
        public PaymentIntentPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If this is a <c>eps</c> PaymentMethod, this sub-hash contains details about the EPS
        /// payment method options.
        /// </summary>
        [JsonProperty("eps")]
        public PaymentIntentPaymentMethodOptionsEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is a <c>fpx</c> PaymentMethod, this sub-hash contains details about the FPX
        /// payment method options.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentIntentPaymentMethodOptionsFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this sub-hash contains details about the
        /// Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentIntentPaymentMethodOptionsGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this sub-hash contains details about the
        /// Grabpay payment method options.
        /// </summary>
        [JsonProperty("grabpay")]
        public PaymentIntentPaymentMethodOptionsGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// If this is a <c>ideal</c> PaymentMethod, this sub-hash contains details about the Ideal
        /// payment method options.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentIntentPaymentMethodOptionsIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is a <c>interac_present</c> PaymentMethod, this sub-hash contains details about
        /// the Card Present payment method options.
        /// </summary>
        [JsonProperty("interac_present")]
        public PaymentIntentPaymentMethodOptionsInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this sub-hash contains details about the
        /// Klarna payment method options.
        /// </summary>
        [JsonProperty("klarna")]
        public PaymentIntentPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this sub-hash contains details about the
        /// Konbini payment method options.
        /// </summary>
        [JsonProperty("konbini")]
        public PaymentIntentPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonProperty("link")]
        public PaymentIntentPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a <c>MobilePay</c> PaymentMethod, this sub-hash contains details about the
        /// MobilePay payment method options.
        /// </summary>
        [JsonProperty("mobilepay")]
        public PaymentIntentPaymentMethodOptionsMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// If this is a <c>oxxo</c> PaymentMethod, this sub-hash contains details about the OXXO
        /// payment method options.
        /// </summary>
        [JsonProperty("oxxo")]
        public PaymentIntentPaymentMethodOptionsOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this sub-hash contains details about the
        /// Przelewy24 payment method options.
        /// </summary>
        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodOptionsP24Options P24 { get; set; }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this sub-hash contains details about the
        /// PayNow payment method options.
        /// </summary>
        [JsonProperty("paynow")]
        public PaymentIntentPaymentMethodOptionsPaynowOptions Paynow { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this sub-hash contains details about the
        /// PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
        public PaymentIntentPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>pix</c> PaymentMethod, this sub-hash contains details about the Pix
        /// payment method options.
        /// </summary>
        [JsonProperty("pix")]
        public PaymentIntentPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this sub-hash contains details about the
        /// PromptPay payment method options.
        /// </summary>
        [JsonProperty("promptpay")]
        public PaymentIntentPaymentMethodOptionsPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// If this is a <c>revolut_pay</c> PaymentMethod, this sub-hash contains details about the
        /// Revolut Pay payment method options.
        /// </summary>
        [JsonProperty("revolut_pay")]
        public PaymentIntentPaymentMethodOptionsRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this sub-hash contains details about the
        /// SOFORT payment method options.
        /// </summary>
        [JsonProperty("sofort")]
        public PaymentIntentPaymentMethodOptionsSofortOptions Sofort { get; set; }

        /// <summary>
        /// If this is a <c>Swish</c> PaymentMethod, this sub-hash contains details about the Swish
        /// payment method options.
        /// </summary>
        [JsonProperty("swish")]
        public PaymentIntentPaymentMethodOptionsSwishOptions Swish { get; set; }

        /// <summary>
        /// If this is a <c>us_bank_account</c> PaymentMethod, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public PaymentIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// If this is a <c>wechat_pay</c> PaymentMethod, this sub-hash contains details about the
        /// WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public PaymentIntentPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// If this is a <c>zip</c> PaymentMethod, this sub-hash contains details about the Zip
        /// payment method options.
        /// </summary>
        [JsonProperty("zip")]
        public PaymentIntentPaymentMethodOptionsZipOptions Zip { get; set; }
    }
}
