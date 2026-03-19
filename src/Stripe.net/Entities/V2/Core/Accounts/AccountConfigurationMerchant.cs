// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationMerchant : StripeEntity<AccountConfigurationMerchant>
    {
        /// <summary>
        /// Indicates whether the merchant configuration is active. You can deactivate or reactivate
        /// the merchant configuration by updating this property. Deactivating the configuration by
        /// setting this value to false doesn't delete the configuration's properties.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool Applied { get; set; }

        /// <summary>
        /// Settings for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public AccountConfigurationMerchantBacsDebitPayments BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings used to apply the merchant's branding to email receipts, invoices, Checkout,
        /// and other products.
        /// </summary>
        [JsonProperty("branding")]
        [STJS.JsonPropertyName("branding")]
        public AccountConfigurationMerchantBranding Branding { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Merchant Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountConfigurationMerchantCapabilities Capabilities { get; set; }

        /// <summary>
        /// Card payments settings.
        /// </summary>
        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public AccountConfigurationMerchantCardPayments CardPayments { get; set; }

        /// <summary>
        /// Settings specific to Konbini payments on the account.
        /// </summary>
        [JsonProperty("konbini_payments")]
        [STJS.JsonPropertyName("konbini_payments")]
        public AccountConfigurationMerchantKonbiniPayments KonbiniPayments { get; set; }

        /// <summary>
        /// The Merchant Category Code (MCC) for the merchant. MCCs classify businesses based on the
        /// goods or services they provide.
        /// </summary>
        [JsonProperty("mcc")]
        [STJS.JsonPropertyName("mcc")]
        public string Mcc { get; set; }

        /// <summary>
        /// Settings for the default text that appears on statements for language variations.
        /// </summary>
        [JsonProperty("script_statement_descriptor")]
        [STJS.JsonPropertyName("script_statement_descriptor")]
        public AccountConfigurationMerchantScriptStatementDescriptor ScriptStatementDescriptor { get; set; }

        /// <summary>
        /// Settings for SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
        [STJS.JsonPropertyName("sepa_debit_payments")]
        public AccountConfigurationMerchantSepaDebitPayments SepaDebitPayments { get; set; }

        /// <summary>
        /// Settings for Smart Disputes automatic response feature.
        /// </summary>
        [JsonProperty("smart_disputes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smart_disputes")]
#endif
        public AccountConfigurationMerchantSmartDisputes SmartDisputes { get; set; }

        /// <summary>
        /// Statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public AccountConfigurationMerchantStatementDescriptor StatementDescriptor { get; set; }

        /// <summary>
        /// Publicly available contact information for sending support issues to.
        /// </summary>
        [JsonProperty("support")]
        [STJS.JsonPropertyName("support")]
        public AccountConfigurationMerchantSupport Support { get; set; }
    }
}
