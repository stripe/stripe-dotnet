// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPaymentSettingsPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("acss_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("acss_debit")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("bancontact")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bancontact")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontactOptions Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsCardOptions Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("customer_balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_balance")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalanceOptions CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Indonesia bank transfer payment method options
        /// to pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("id_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id_bank_transfer")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsIdBankTransferOptions IdBankTransfer { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("konbini")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbiniOptions Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options to
        /// pass to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("sepa_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebitOptions SepaDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the UPI payment method options to pass to the
        /// invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("upi")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("upi")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpiOptions Upi { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to the invoice’s PaymentIntent.
        /// </summary>
        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccountOptions UsBankAccount { get; set; }
    }
}
