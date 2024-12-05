// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionPaymentSettingsPaymentMethodOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("acss_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("bancontact")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonProperty("card")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("customer_balance")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("konbini")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options to
        /// pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("sepa_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to invoices created by the subscription.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
