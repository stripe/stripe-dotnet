// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptions>
    {
        /// <summary>
        /// This sub-hash contains details about the Canadian pre-authorized debit payment method
        /// options to pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("acss_debit")]
        [STJS.JsonPropertyName("acss_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsAcssDebit AcssDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bancontact payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("bancontact")]
        [STJS.JsonPropertyName("bancontact")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBancontact Bancontact { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bizum payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("bizum")]
        [STJS.JsonPropertyName("bizum")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBizum Bizum { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Blik payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonProperty("blik")]
        [STJS.JsonPropertyName("blik")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsBlik Blik { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Card payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonProperty("card")]
        [STJS.JsonPropertyName("card")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCard Card { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Check Scan payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("check_scan")]
        [STJS.JsonPropertyName("check_scan")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCheckScan CheckScan { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Bank transfer payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("customer_balance")]
        [STJS.JsonPropertyName("customer_balance")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsCustomerBalance CustomerBalance { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Indonesia bank transfer payment method options
        /// to pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("id_bank_transfer")]
        [STJS.JsonPropertyName("id_bank_transfer")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsIdBankTransfer IdBankTransfer { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Konbini payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("konbini")]
        [STJS.JsonPropertyName("konbini")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsKonbini Konbini { get; set; }

        /// <summary>
        /// This sub-hash contains details about the PayTo payment method options to pass to
        /// invoices created by the subscription.
        /// </summary>
        [JsonProperty("payto")]
        [STJS.JsonPropertyName("payto")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPayto Payto { get; set; }

        /// <summary>
        /// This sub-hash contains details about the Pix payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonProperty("pix")]
        [STJS.JsonPropertyName("pix")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsPix Pix { get; set; }

        /// <summary>
        /// This sub-hash contains details about the SEPA Direct Debit payment method options to
        /// pass to invoices created by the subscription.
        /// </summary>
        [JsonProperty("sepa_debit")]
        [STJS.JsonPropertyName("sepa_debit")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsSepaDebit SepaDebit { get; set; }

        /// <summary>
        /// This sub-hash contains details about the UPI payment method options to pass to invoices
        /// created by the subscription.
        /// </summary>
        [JsonProperty("upi")]
        [STJS.JsonPropertyName("upi")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUpi Upi { get; set; }

        /// <summary>
        /// This sub-hash contains details about the ACH direct debit payment method options to pass
        /// to invoices created by the subscription.
        /// </summary>
        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public SubscriptionPaymentSettingsPaymentMethodOptionsUsBankAccount UsBankAccount { get; set; }
    }
}
