// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationMerchantOptions : INestedOptions
    {
        /// <summary>
        /// Settings used for Bacs debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bacs_debit_payments")]
#endif
        public AccountCreateConfigurationMerchantBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings used to apply the merchant's branding to email receipts, invoices, Checkout,
        /// and other products.
        /// </summary>
        [JsonProperty("branding")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branding")]
#endif
        public AccountCreateConfigurationMerchantBrandingOptions Branding { get; set; }

        /// <summary>
        /// Capabilities to request on the Merchant Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("capabilities")]
#endif
        public AccountCreateConfigurationMerchantCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// Card payments settings.
        /// </summary>
        [JsonProperty("card_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_payments")]
#endif
        public AccountCreateConfigurationMerchantCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Settings specific to Konbini payments on the account.
        /// </summary>
        [JsonProperty("konbini_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("konbini_payments")]
#endif
        public AccountCreateConfigurationMerchantKonbiniPaymentsOptions KonbiniPayments { get; set; }

        /// <summary>
        /// The Merchant Category Code (MCC) for the Merchant Configuration. MCCs classify
        /// businesses based on the goods or services they provide.
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
        public AccountCreateConfigurationMerchantScriptStatementDescriptorOptions ScriptStatementDescriptor { get; set; }

        /// <summary>
        /// Settings used for Smart Disputes.
        /// </summary>
        [JsonProperty("smart_disputes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smart_disputes")]
#endif
        public AccountCreateConfigurationMerchantSmartDisputesOptions SmartDisputes { get; set; }

        /// <summary>
        /// Statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public AccountCreateConfigurationMerchantStatementDescriptorOptions StatementDescriptor { get; set; }

        /// <summary>
        /// Publicly available contact information for sending support issues to.
        /// </summary>
        [JsonProperty("support")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("support")]
#endif
        public AccountCreateConfigurationMerchantSupportOptions Support { get; set; }
    }
}
