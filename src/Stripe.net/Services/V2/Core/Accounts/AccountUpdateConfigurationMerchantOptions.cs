// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationMerchantOptions : INestedOptions
    {
        /// <summary>
        /// Represents the state of the configuration, and can be updated to deactivate or re-apply
        /// a configuration.
        /// </summary>
        [JsonProperty("applied")]
        [STJS.JsonPropertyName("applied")]
        public bool? Applied { get; set; }

        /// <summary>
        /// Settings for Bacs Direct Debit payments.
        /// </summary>
        [JsonProperty("bacs_debit_payments")]
        [STJS.JsonPropertyName("bacs_debit_payments")]
        public AccountUpdateConfigurationMerchantBacsDebitPaymentsOptions BacsDebitPayments { get; set; }

        /// <summary>
        /// Settings used to apply the merchant's branding to email receipts, invoices, Checkout,
        /// and other products.
        /// </summary>
        [JsonProperty("branding")]
        [STJS.JsonPropertyName("branding")]
        public AccountUpdateConfigurationMerchantBrandingOptions Branding { get; set; }

        /// <summary>
        /// Capabilities to request on the Merchant Configuration.
        /// </summary>
        [JsonProperty("capabilities")]
        [STJS.JsonPropertyName("capabilities")]
        public AccountUpdateConfigurationMerchantCapabilitiesOptions Capabilities { get; set; }

        /// <summary>
        /// Card payments settings.
        /// </summary>
        [JsonProperty("card_payments")]
        [STJS.JsonPropertyName("card_payments")]
        public AccountUpdateConfigurationMerchantCardPaymentsOptions CardPayments { get; set; }

        /// <summary>
        /// Settings specific to Konbini payments on the account.
        /// </summary>
        [JsonProperty("konbini_payments")]
        [STJS.JsonPropertyName("konbini_payments")]
        public AccountUpdateConfigurationMerchantKonbiniPaymentsOptions KonbiniPayments { get; set; }

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
        public AccountUpdateConfigurationMerchantScriptStatementDescriptorOptions ScriptStatementDescriptor { get; set; }

        /// <summary>
        /// Settings for Smart Disputes automatic response feature.
        /// </summary>
        [JsonProperty("smart_disputes")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("smart_disputes")]
#endif
        public AccountUpdateConfigurationMerchantSmartDisputesOptions SmartDisputes { get; set; }

        /// <summary>
        /// Settings for the default <a
        /// href="https://stripe.com/connect/statement-descriptors">statement descriptor</a> text.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public AccountUpdateConfigurationMerchantStatementDescriptorOptions StatementDescriptor { get; set; }

        /// <summary>
        /// Publicly available contact information for sending support issues to.
        /// </summary>
        [JsonProperty("support")]
        [STJS.JsonPropertyName("support")]
        public AccountUpdateConfigurationMerchantSupportOptions Support { get; set; }
    }
}
