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
        /// If this is a <c>boleto</c> PaymentMethod, this hash contains details about the Boleto
        /// payment method.
        /// </summary>
        [JsonProperty("boleto")]
        public PaymentIntentPaymentMethodDataBoletoOptions Boleto { get; set; }

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
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

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
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>acss_debit</c>, <c>afterpay_clearpay</c>, <c>alipay</c>,
        /// <c>au_becs_debit</c>, <c>bacs_debit</c>, <c>bancontact</c>, <c>boleto</c>, <c>eps</c>,
        /// <c>fpx</c>, <c>giropay</c>, <c>grabpay</c>, <c>ideal</c>, <c>oxxo</c>, <c>p24</c>,
        /// <c>sepa_debit</c>, <c>sofort</c>, or <c>wechat_pay</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// If this is an <c>wechat_pay</c> PaymentMethod, this hash contains details about the
        /// wechat_pay payment method.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public PaymentIntentPaymentMethodDataWechatPayOptions WechatPay { get; set; }
    }
}
