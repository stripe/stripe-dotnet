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
        /// Settings used for Bacs debit payments.
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
        /// The merchant category code for the merchant. MCCs are used to classify businesses based
        /// on the goods or services they provide.
        /// </summary>
        [JsonProperty("mcc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mcc")]
#endif
        public string Mcc { get; set; }

        /// <summary>
        /// Settings used for SEPA debit payments.
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
