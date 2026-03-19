// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptions : StripeEntity<InvoicePaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// If paying by <c>acss_debit</c>, this sub-hash contains details about the Canadian
        /// pre-authorized debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public InvoicePaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// If paying by <c>bancontact</c>, this sub-hash contains details about the Bancontact
        /// payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public InvoicePaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// If paying by <c>card</c>, this sub-hash contains details about the Card payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public InvoicePaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// If paying by <c>customer_balance</c>, this sub-hash contains details about the Bank
        /// transfer payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public InvoicePaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// If paying by <c>konbini</c>, this sub-hash contains details about the Konbini payment
        /// method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public InvoicePaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// If paying by <c>payto</c>, this sub-hash contains details about the PayTo payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public InvoicePaymentSettingsPaymentMethodOptionsPayto Payto { get; set; }

        /// <summary>
        /// If paying by <c>sepa_debit</c>, this sub-hash contains details about the SEPA Direct
        /// Debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public InvoicePaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// If paying by <c>us_bank_account</c>, this sub-hash contains details about the ACH direct
        /// debit payment method options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public InvoicePaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
