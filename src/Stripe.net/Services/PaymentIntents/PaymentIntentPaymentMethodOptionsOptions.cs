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
        /// If this is a <c>bancontact</c> PaymentMethod, this sub-hash contains details about the
        /// Bancontact payment method options.
        /// </summary>
        [JsonProperty("bancontact")]
        public PaymentIntentPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

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
        /// If this is a <c>giropay</c> PaymentMethod, this sub-hash contains details about the
        /// Giropay payment method options.
        /// </summary>
        [JsonProperty("giropay")]
        public PaymentIntentPaymentMethodOptionsGiropayOptions Giropay { get; set; }

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
        /// If this is a <c>wechat_pay</c> PaymentMethod, this sub-hash contains details about the
        /// WeChat Pay payment method options.
        /// </summary>
        [JsonProperty("wechat_pay")]
        public PaymentIntentPaymentMethodOptionsWechatPayOptions WechatPay { get; set; }
    }
}
