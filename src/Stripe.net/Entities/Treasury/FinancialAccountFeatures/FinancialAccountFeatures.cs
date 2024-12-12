// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Encodes whether a FinancialAccount has access to a particular Feature, with a
    /// <c>status</c> enum and associated <c>status_details</c>. Stripe or the platform can
    /// control Features via the requested field.
    /// </summary>
    public class FinancialAccountFeatures : StripeEntity<FinancialAccountFeatures>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonProperty("card_issuing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("card_issuing")]
#endif
        public FinancialAccountFeaturesCardIssuing CardIssuing { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonProperty("deposit_insurance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deposit_insurance")]
#endif
        public FinancialAccountFeaturesDepositInsurance DepositInsurance { get; set; }

        /// <summary>
        /// Settings related to Financial Addresses features on a Financial Account.
        /// </summary>
        [JsonProperty("financial_addresses")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_addresses")]
#endif
        public FinancialAccountFeaturesFinancialAddresses FinancialAddresses { get; set; }

        /// <summary>
        /// InboundTransfers contains inbound transfers features for a FinancialAccount.
        /// </summary>
        [JsonProperty("inbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inbound_transfers")]
#endif
        public FinancialAccountFeaturesInboundTransfers InboundTransfers { get; set; }

        /// <summary>
        /// Toggle settings for enabling/disabling a feature.
        /// </summary>
        [JsonProperty("intra_stripe_flows")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("intra_stripe_flows")]
#endif
        public FinancialAccountFeaturesIntraStripeFlows IntraStripeFlows { get; set; }

        /// <summary>
        /// Settings related to Outbound Payments features on a Financial Account.
        /// </summary>
        [JsonProperty("outbound_payments")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_payments")]
#endif
        public FinancialAccountFeaturesOutboundPayments OutboundPayments { get; set; }

        /// <summary>
        /// OutboundTransfers contains outbound transfers features for a FinancialAccount.
        /// </summary>
        [JsonProperty("outbound_transfers")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outbound_transfers")]
#endif
        public FinancialAccountFeaturesOutboundTransfers OutboundTransfers { get; set; }
    }
}
