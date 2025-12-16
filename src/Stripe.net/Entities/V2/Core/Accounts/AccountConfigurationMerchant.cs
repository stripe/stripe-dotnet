// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationMerchant : StripeEntity<AccountConfigurationMerchant>
    {
        /// <summary>
        /// Indicates whether the merchant configuration is active. You can deactivate or reactivate
        /// the merchant configuration by updating this property. Deactivating the configuration by
        /// setting this value to false doesn't delete the configuration's properties.
        /// </summary>
        [JsonProperty("applied")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied")]
#endif
        public bool Applied { get; set; }

        /// <summary>
        /// Settings for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public AccountConfigurationMerchantBacsDebitPayments BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings used to apply the merchant's branding to email receipts, invoices, Checkout,
        /// and other products.
        /// </summary>
        [JsonProperty("branding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branding")]
#endif
        public AccountConfigurationMerchantBranding Branding { get; set; }

        /// <summary>
        /// Capabilities that have been requested on the Merchant Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountConfigurationMerchantCapabilities Capabilities { get; set; }

        /// <summary>
        /// Card payments settings.
        /// </summary>
        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public AccountConfigurationMerchantCardPayments CardPayments { get; set; }

        /// <summary>
        /// Settings specific to Konbini payments on the account.
        /// </summary>
        [JsonProperty("konbini_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini_payments")]
#endif
        public AccountConfigurationMerchantKonbiniPayments KonbiniPayments { get; set; }

        /// <summary>
        /// The Merchant Category Code (MCC) for the merchant. MCCs classify businesses based on the
        /// goods or services they provide.
        /// </summary>
        [JsonProperty("mcc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mcc")]
#endif
        public string Mcc { get; set; }

        /// <summary>
        /// Settings for the default text that appears on statements for language variations.
        /// </summary>
        [JsonProperty("script_statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("script_statement_descriptor")]
#endif
        public AccountConfigurationMerchantScriptStatementDescriptor ScriptStatementDescriptor { get; set; }

        /// <summary>
        /// Settings for SEPA Direct Debit payments.
        /// </summary>
        [JsonProperty("sepa_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sepa_debit_payments")]
#endif
        public AccountConfigurationMerchantSepaDebitPayments SepaDebitPayments { get; set; }

        /// <summary>
        /// Statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public AccountConfigurationMerchantStatementDescriptor StatementDescriptor { get; set; }

        /// <summary>
        /// Publicly available contact information for sending support issues to.
        /// </summary>
        [JsonProperty("support")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support")]
#endif
        public AccountConfigurationMerchantSupport Support { get; set; }
    }
}
