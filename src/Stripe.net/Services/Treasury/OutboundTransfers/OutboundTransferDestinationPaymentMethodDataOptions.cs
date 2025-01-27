// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundTransferDestinationPaymentMethodDataOptions : INestedOptions
    {
        /// <summary>
        /// Required if type is set to <c>financial_account</c>. The FinancialAccount ID to send
        /// funds to.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// The type of the destination.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
