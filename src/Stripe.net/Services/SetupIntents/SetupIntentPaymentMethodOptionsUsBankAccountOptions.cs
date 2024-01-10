// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Additional fields for Financial Connections Session creation.
        /// </summary>
        [JsonProperty("financial_connections")]
        public SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsOptions FinancialConnections { get; set; }

        /// <summary>
        /// Additional fields for Mandate creation.
        /// </summary>
        [JsonProperty("mandate_options")]
        public SetupIntentPaymentMethodOptionsUsBankAccountMandateOptionsOptions MandateOptions { get; set; }

        /// <summary>
        /// Additional fields for network related functions.
        /// </summary>
        [JsonProperty("networks")]
        public SetupIntentPaymentMethodOptionsUsBankAccountNetworksOptions Networks { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
