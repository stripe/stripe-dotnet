// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>acss_debit</c> SetupIntent, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public SetupIntentPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is a <c>amazon_pay</c> SetupIntent, this sub-hash contains details about the
        /// AmazonPay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
        [STJS.JsonPropertyName("amazon_pay")]
        public SetupIntentPaymentMethodOptionsAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> SetupIntent, this sub-hash contains details about the
        /// Bacs Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
        [STJS.JsonPropertyName("bacs_debit")]
        public SetupIntentPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// Configuration for any card setup attempted on this SetupIntent.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SetupIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>card_present</c> PaymentMethod, this sub-hash contains details about the
        /// card-present payment method options.
        /// </summary>
        [JsonProperty("card_present")]
        [STJS.JsonPropertyName("card_present")]
        public SetupIntentPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// If this is a <c>klarna</c> PaymentMethod, this hash contains details about the Klarna
        /// payment method options.
        /// </summary>
        [JsonProperty("klarna")]
        [STJS.JsonPropertyName("klarna")]
        public SetupIntentPaymentMethodOptionsKlarnaOptions Klarna { get; set; }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonProperty("link")]
        [STJS.JsonPropertyName("link")]
        public SetupIntentPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this sub-hash contains details about the
        /// PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
        [STJS.JsonPropertyName("paypal")]
        public SetupIntentPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>payto</c> SetupIntent, this sub-hash contains details about the PayTo
        /// payment method options.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public SetupIntentPaymentMethodOptionsPaytoOptions Payto { get; set; }

        /// <summary>
        /// If this is a <c>pix</c> SetupIntent, this sub-hash contains details about the Pix
        /// payment method options.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public SetupIntentPaymentMethodOptionsPixOptions Pix { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> SetupIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SetupIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>us_bank_account</c> SetupIntent, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public SetupIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
