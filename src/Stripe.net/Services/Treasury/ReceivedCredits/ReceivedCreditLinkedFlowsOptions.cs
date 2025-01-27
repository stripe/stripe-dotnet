// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditLinkedFlowsOptions : INestedOptions
    {
        /// <summary>
        /// The source flow type.
        /// One of: <c>credit_reversal</c>, <c>other</c>, <c>outbound_payment</c>,
        /// <c>outbound_transfer</c>, or <c>payout</c>.
        /// </summary>
        [JsonProperty("source_flow_type")]
        public string SourceFlowType { get; set; }
    }
}
