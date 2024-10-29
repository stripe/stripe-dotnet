// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptions : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the Canadian
        /// pre-authorized debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// If paying by <c>customer_balance</c>, this sub-hash contains details about the Bank
        /// transfer payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// If paying by <c>id_bank_transfer</c>, this sub-hash contains details about the Indonesia
        /// bank transfer payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("id_bank_transfer")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsIdBankTransfer IdBankTransfer { get; set; }

        /// <summary>
        /// If paying by <c>konbini</c>, this sub-hash contains details about the Konbini payment
        /// method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("konbini")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// If paying by <c>sepa_debit</c>, this sub-hash contains details about the SEPA Direct
        /// Debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// If paying by <c>us_bank_account</c>, this sub-hash contains details about the ACH direct
        /// debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
