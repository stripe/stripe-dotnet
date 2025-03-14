// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// If this is a <c>acss_debit</c> SetupIntent, this sub-hash contains details about the
        /// ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public SetupIntentPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// If this is a <c>amazon_pay</c> SetupIntent, this sub-hash contains details about the
        /// AmazonPay payment method options.
        /// </summary>
        [JsonProperty("amazon_pay")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amazon_pay")]
#endif
        public SetupIntentPaymentMethodOptionsAmazonPayOptions AmazonPay { get; set; }

        /// <summary>
        /// If this is a <c>bacs_debit</c> SetupIntent, this sub-hash contains details about the
        /// Bacs Debit payment method options.
        /// </summary>
        [JsonProperty("bacs_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit")]
#endif
        public SetupIntentPaymentMethodOptionsBacsDebitOptions BacsDebit { get; set; }

        /// <summary>
        /// Configuration for any card setup attempted on this SetupIntent.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SetupIntentPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// If this is a <c>card_present</c> PaymentMethod, this sub-hash contains details about the
        /// card-present payment method options.
        /// </summary>
        [JsonProperty("card_present")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_present")]
#endif
        public SetupIntentPaymentMethodOptionsCardPresentOptions CardPresent { get; set; }

        /// <summary>
        /// If this is a <c>link</c> PaymentMethod, this sub-hash contains details about the Link
        /// payment method options.
        /// </summary>
        [JsonProperty("link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("link")]
#endif
        public SetupIntentPaymentMethodOptionsLinkOptions Link { get; set; }

        /// <summary>
        /// If this is a <c>paypal</c> PaymentMethod, this sub-hash contains details about the
        /// PayPal payment method options.
        /// </summary>
        [JsonProperty("paypal")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("paypal")]
#endif
        public SetupIntentPaymentMethodOptionsPaypalOptions Paypal { get; set; }

        /// <summary>
        /// If this is a <c>payto</c> SetupIntent, this sub-hash contains details about the PayTo
        /// payment method options.
        /// </summary>
        [JsonProperty("payto")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payto")]
#endif
        public SetupIntentPaymentMethodOptionsPaytoOptions Payto { get; set; }

        /// <summary>
        /// If this is a <c>sepa_debit</c> SetupIntent, this sub-hash contains details about the
        /// SEPA Debit payment method options.
        /// </summary>
        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public SetupIntentPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// If this is a <c>us_bank_account</c> SetupIntent, this sub-hash contains details about
        /// the US bank account payment method options.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public SetupIntentPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
