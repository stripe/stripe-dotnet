// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// If this is an <c>acss_debit</c> PaymentMethod, this hash contains details about the ACSS
        /// Debit payment method.
        /// </summary>
        [JsonProperty("acss_debit")]
        public PaymentIntentPaymentMethodDataAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is an <c>affirm</c> PaymentMethod, this hash contains details about the Affirm
        /// payment method.
        /// </summary>
        [JsonProperty("affirm")]
        public PaymentIntentPaymentMethodDataAffirmOptions Affirm { get; set; }

        /// <summary>
        /// If this is an <c>AfterpayClearpay</c> PaymentMethod, this hash contains details about
        /// the AfterpayClearpay payment method.
        /// </summary>
        [JsonProperty("afterpay_clearpay")]
        public PaymentIntentPaymentMethodDataAfterpayClearpayOptions AfterpayClearpay { get; set; }

        /// <summary>
        /// If this is an <c>Alipay</c> PaymentMethod, this hash contains details about the Alipay
        /// payment method.
        /// </summary>
        [JsonProperty("alipay")]
        public PaymentIntentPaymentMethodDataAlipayOptions Alipay { get; set; }

        /// <summary>
        /// If this is an <c>au_becs_debit</c> PaymentMethod, this hash contains details about the
        /// bank account.
        /// </summary>
        [JsonProperty("au_becs_debit")]
        public PaymentIntentPaymentMethodDataAuBecsDebitOptions AuBecsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> PaymentMethod, this hash contains details about the Bacs
        /// Direct Debit bank account.
        /// </summary>
        [JsonProperty("bacs_debit")]
        public PaymentIntentPaymentMethodDataBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// If this is a <c>bancontact</c> PaymentMethod, this hash contains details about the
        /// Bancontact payment method.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodDataBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public PaymentIntentPaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// If this is a <c>blik</c> PaymentMethod, this hash contains details about the BLIK
        /// payment method.
        /// </summary>
        [JsonProperty("blik")]
        public PaymentIntentPaymentMethodDataBlikOptions Blik { get; set; }

        /// <summary>
        /// If this is a <c>boleto</c> PaymentMethod, this hash contains details about the Boleto
        /// payment method.
        /// </summary>
        [JsonProperty("boleto")]
        public PaymentIntentPaymentMethodDataBoletoOptions Boleto { get; set; }

        /// <summary>
        /// If this is a <c>cashapp</c> PaymentMethod, this hash contains details about the Cash App
        /// Pay payment method.
        /// </summary>
        [JsonProperty("cashapp")]
        public PaymentIntentPaymentMethodDataCashappOptions Cashapp { get; set; }

        /// <summary>
        /// If this is a <c>customer_balance</c> PaymentMethod, this hash contains details about the
        /// CustomerBalance payment method.
        /// </summary>
        [JsonProperty("customer_balance")]
        public PaymentIntentPaymentMethodDataCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// If this is an <c>eps</c> PaymentMethod, this hash contains details about the EPS payment
        /// method.
        /// </summary>
        [JsonProperty("eps")]
        public PaymentIntentPaymentMethodDataEpsOptions Eps { get; set; }

        /// <summary>
        /// If this is an <c>fpx</c> PaymentMethod, this hash contains details about the FPX payment
        /// method.
        /// </summary>
        [JsonProperty("fpx")]
        public PaymentIntentPaymentMethodDataFpxOptions Fpx { get; set; }

        /// <summary>
        /// If this is a <c>giropay</c> PaymentMethod, this hash contains details about the Giropay
        /// payment method.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentIntentPaymentMethodDataGiropayOptions Giropay { get; set; }

        /// <summary>
        /// If this is a <c>grabpay</c> PaymentMethod, this hash contains details about the GrabPay
        /// payment method.
        /// </summary>
        [JsonProperty("grabpay")]
        public PaymentIntentPaymentMethodDataGrabpayOptions Grabpay { get; set; }

        /// <summary>
        /// If this is an <c>ideal</c> PaymentMethod, this hash contains details about the iDEAL
        /// payment method.
        /// </summary>
        [JsonProperty("ideal")]
        public PaymentIntentPaymentMethodDataIdealOptions Ideal { get; set; }

        /// <summary>
        /// If this is an <c>interac_present</c> PaymentMethod, this hash contains details about the
        /// Interac Present payment method.
        /// </summary>
        [JsonProperty("interac_present")]
        public PaymentIntentPaymentMethodDataInteracPresentOptions InteracPresent { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this hash contains details about the Klarna
        /// payment method.
        /// </summary>
        [JsonProperty("klarna")]
        public PaymentIntentPaymentMethodDataKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>konbini</c> PaymentMethod, this hash contains details about the Konbini
        /// payment method.
        /// </summary>
        [JsonProperty("konbini")]
        public PaymentIntentPaymentMethodDataKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// If this is an <c>Link</c> PaymentMethod, this hash contains details about the Link
        /// payment method.
        /// </summary>
        [JsonProperty("link")]
        public PaymentIntentPaymentMethodDataLinkOptions Link { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// If this is a <c>mobilepay</c> PaymentMethod, this hash contains details about the
        /// MobilePay payment method.
        /// </summary>
        [JsonProperty("mobilepay")]
        public PaymentIntentPaymentMethodDataMobilepayOptions Mobilepay { get; set; }

        /// <summary>
        /// If this is an <c>oxxo</c> PaymentMethod, this hash contains details about the OXXO
        /// payment method.
        /// </summary>
        [JsonProperty("oxxo")]
        public PaymentIntentPaymentMethodDataOxxoOptions Oxxo { get; set; }

        /// <summary>
        /// If this is a <c>p24</c> PaymentMethod, this hash contains details about the P24 payment
        /// method.
        /// </summary>
        [JsonProperty("p24")]
        public PaymentIntentPaymentMethodDataP24Options P24 { get; set; }

        /// <summary>
        /// If this is a <c>paynow</c> PaymentMethod, this hash contains details about the PayNow
        /// payment method.
        /// </summary>
        [JsonProperty("paynow")]
        public PaymentIntentPaymentMethodDataPaynowOptions Paynow { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this hash contains details about the PayPal
        /// payment method.
        /// </summary>
        [JsonProperty("paypal")]
        public PaymentIntentPaymentMethodDataPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>pix</c> PaymentMethod, this hash contains details about the Pix payment
        /// method.
        /// </summary>
        [JsonProperty("pix")]
        public PaymentIntentPaymentMethodDataPixOptions Pix { get; set; }

        /// <summary>
        /// If this is a <c>promptpay</c> PaymentMethod, this hash contains details about the
        /// PromptPay payment method.
        /// </summary>
        [JsonProperty("promptpay")]
        public PaymentIntentPaymentMethodDataPromptpayOptions Promptpay { get; set; }

        /// <summary>
        /// Options to configure Radar. See <a
        /// href="https://stripe.com/docs/radar/radar-session">Radar Session</a> for more
        /// information.
        /// </summary>
        [JsonProperty("radar_options")]
        public PaymentIntentPaymentMethodDataRadarOptionsOptions RadarOptions { get; set; }

        /// <summary>
        /// If this is a <c>Revolut Pay</c> PaymentMethod, this hash contains details about the
        /// Revolut Pay payment method.
        /// </summary>
        [JsonProperty("revolut_pay")]
        public PaymentIntentPaymentMethodDataRevolutPayOptions RevolutPay { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> PaymentMethod, this hash contains details about the SEPA
        /// debit bank account.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public PaymentIntentPaymentMethodDataSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>sofort</c> PaymentMethod, this hash contains details about the SOFORT
        /// payment method.
        /// </summary>
        [JsonProperty("sofort")]
        public PaymentIntentPaymentMethodDataSofortOptions Sofort { get; set; }

        /// <summary>
        /// If this is a <c>swish</c> PaymentMethod, this hash contains details about the Swish
        /// payment method.
        /// </summary>
        [JsonProperty("swish")]
        public PaymentIntentPaymentMethodDataSwishOptions Swish { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>affirm</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>blik</c>, <c>boleto</c>,
        /// <c>cashapp</c>, <c>customer_balance</c>, <c>eps</c>, <c>fpx</c>, <c>giropay</c>,
        /// <c>grabpay</c>, <c>ideal</c>, <c>klarna</c>, <c>konbini</c>, <c>link</c>,
        /// <c>mobilepay</c>, <c>oxxo</c>, <c>p24</c>, <c>paynow</c>, <c>paypal</c>, <c>pix</c>,
        /// <c>promptpay</c>, <c>revolut_pay</c>, <c>sepa_debit</c>, <c>sofort</c>, <c>swish</c>,
        /// <c>us_bank_account</c>, <c>wechat_pay</c>, or <c>zip</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If this is an <c>us_bank_account</c> PaymentMethod, this hash contains details about the
        /// US bank account payment method.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public PaymentIntentPaymentMethodDataUsBankAccountOptions UsBankAccount { get; set; }

        /// <summary>
        /// If this is an <c>wechat_pay</c> PaymentMethod, this hash contains details about the
        /// wechat_pay payment method.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public PaymentIntentPaymentMethodDataWechatPayOptions WechatPay { get; set; }

        /// <summary>
        /// If this is a <c>zip</c> PaymentMethod, this hash contains details about the Zip payment
        /// method.
        /// </summary>
        [JsonProperty("zip")]
        public PaymentIntentPaymentMethodDataZipOptions Zip { get; set; }
    }
}
