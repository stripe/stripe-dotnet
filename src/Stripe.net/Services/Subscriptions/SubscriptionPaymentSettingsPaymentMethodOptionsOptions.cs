// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("konbini")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options to
        /// pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
