// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Financial Connections Session creation.
        /// </summary>
        [JsonProperty("financial_connections")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_connections")]
#endif

        public SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions FinancialConnections { get; set; }

        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("mandate_options")]
#endif

        public SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// Additional fields for network related functions.
        /// </summary>
        [JsonProperty("networks")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("networks")]
#endif

        public SetupIntentPaymentMethodOptionsUsBankAccountNetworksOptions Networks { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification_method")]
#endif

        public string VerificationMethod { get; set; }
    }
}
