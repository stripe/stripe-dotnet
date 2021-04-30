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
        /// Configuration for any card payments attempted on this PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public PaymentIntentPaymentMethodOptionsCardOptions Card { get; set; }

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
    }
}
