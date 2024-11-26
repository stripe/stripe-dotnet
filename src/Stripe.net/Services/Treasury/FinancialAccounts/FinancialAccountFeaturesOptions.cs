// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAccountFeaturesOptions : INestedOptions
    {
        /// <summary>
        /// Encodes the FinancialAccount's ability to be used with the Issuing product, including
        /// attaching cards to and drawing funds from the FinancialAccount.
        /// </summary>
        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public FinancialAccountFeaturesCardIssuingOptions CardIssuing { get; set; }

        /// <summary>
        /// Represents whether this FinancialAccount is eligible for deposit insurance. Various
        /// factors determine the insurance amount.
        /// </summary>
        [JsonProperty("deposit_insurance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deposit_insurance")]
#endif
        public FinancialAccountFeaturesDepositInsuranceOptions DepositInsurance { get; set; }

        /// <summary>
        /// Contains Features that add FinancialAddresses to the FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_addresses")]
#endif
        public FinancialAccountFeaturesFinancialAddressesOptions FinancialAddresses { get; set; }

        /// <summary>
        /// Contains settings related to adding funds to a FinancialAccount from another Account
        /// with the same owner.
        /// </summary>
        [JsonProperty("inbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfers")]
#endif
        public FinancialAccountFeaturesInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Represents the ability for the FinancialAccount to send money to, or receive money from
        /// other FinancialAccounts (for example, via OutboundPayment).
        /// </summary>
        [JsonProperty("intra_stripe_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("intra_stripe_flows")]
#endif
        public FinancialAccountFeaturesIntraStripeFlowsOptions IntraStripeFlows { get; set; }

        /// <summary>
        /// Includes Features related to initiating money movement out of the FinancialAccount to
        /// someone else's bucket of money.
        /// </summary>
        [JsonProperty("outbound_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payments")]
#endif
        public FinancialAccountFeaturesOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Contains a Feature and settings related to moving money out of the FinancialAccount into
        /// another Account with the same owner.
        /// </summary>
        [JsonProperty("outbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfers")]
#endif
        public FinancialAccountFeaturesOutboundTransfersOptions OutboundTransfers { get; set; }
    }
}
