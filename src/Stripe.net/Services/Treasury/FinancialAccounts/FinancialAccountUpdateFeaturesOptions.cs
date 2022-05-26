// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountUpdateFeaturesOptions : BaseOptions
    {
        /// <summary>
        /// Represents whether this FinancialAccount is eligible for deposit insurance. Various
        /// factors determine the insurance amount.
        /// </summary>
        [JsonProperty("deposit_insurance")]
        public FinancialAccountDepositInsuranceOptions DepositInsurance { get; set; }

        /// <summary>
        /// Contains Features that add FinancialAddresses to the FinancialAccount.
        /// </summary>
        [JsonProperty("financial_addresses")]
        public FinancialAccountFinancialAddressesOptions FinancialAddresses { get; set; }

        /// <summary>
        /// Contains settings related to adding funds to a FinancialAccount from another Account
        /// with the same owner.
        /// </summary>
        [JsonProperty("inbound_transfers")]
        public FinancialAccountInboundTransfersOptions InboundTransfers { get; set; }

        /// <summary>
        /// Represents the ability for the FinancialAccount to send money to, or receive money from
        /// other FinancialAccounts (for example, via OutboundPayment).
        /// </summary>
        [JsonProperty("intra_stripe_flows")]
        public FinancialAccountIntraStripeFlowsOptions IntraStripeFlows { get; set; }

        /// <summary>
        /// Includes Features related to initiating money movement out of the FinancialAccount to
        /// someone else's bucket of money.
        /// </summary>
        [JsonProperty("outbound_payments")]
        public FinancialAccountOutboundPaymentsOptions OutboundPayments { get; set; }

        /// <summary>
        /// Contains a Feature and settings related to moving money out of the FinancialAccount into
        /// another Account with the same owner.
        /// </summary>
        [JsonProperty("outbound_transfers")]
        public FinancialAccountOutboundTransfersOptions OutboundTransfers { get; set; }
    }
}
