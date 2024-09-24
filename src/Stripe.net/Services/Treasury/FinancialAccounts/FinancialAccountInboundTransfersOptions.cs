namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;

    [Obsolete("Use FinancialAccountFeaturesInboundTransfersOptions instead.")]
    public class FinancialAccountInboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH Debits via the InboundTransfers API.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountInboundTransfersAchOptions Ach { get; set; }
    }
}
