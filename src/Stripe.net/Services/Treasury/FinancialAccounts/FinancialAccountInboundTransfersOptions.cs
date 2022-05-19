// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class FinancialAccountInboundTransfersOptions : INestedOptions
    {
        /// <summary>
        /// Enables ACH Debits via the InboundTransfers API.
        /// </summary>
        [JsonProperty("ach")]
        public FinancialAccountInboundTransfersAchOptions Ach { get; set; }
    }
}
