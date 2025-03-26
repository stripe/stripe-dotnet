// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options to
        /// pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to invoices created by the subscription.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
