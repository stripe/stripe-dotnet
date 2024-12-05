// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditLinkedFlows : StripeEntity<ReceivedCreditLinkedFlows>
    {
        /// <summary>
        /// The CreditReversal created as a result of this ReceivedCredit being reversed.
        /// </summary>
        [JsonProperty("credit_reversal")]
        public string CreditReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedCredit was created due to an <a
        /// href="https://stripe.com/docs/api#issuing_authorizations">Issuing Authorization</a>
        /// object.
        /// </summary>
        [JsonProperty("issuing_authorization")]
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedCredit is also viewable as an <a
        /// href="https://stripe.com/docs/api#issuing_transactions">Issuing transaction</a> object.
        /// </summary>
        [JsonProperty("issuing_transaction")]
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// ID of the source flow. Set if <c>network</c> is <c>stripe</c> and the source flow is
        /// visible to the user. Examples of source flows include OutboundPayments, payouts, or
        /// CreditReversals.
        /// </summary>
        [JsonProperty("source_flow")]
        public string SourceFlow { get; set; }

        /// <summary>
        /// The expandable object of the source flow.
        /// </summary>
        [JsonProperty("source_flow_details")]
        public ReceivedCreditLinkedFlowsSourceFlowDetails SourceFlowDetails { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit (for example,
        /// <c>outbound_payment</c>).
        /// </summary>
        [JsonProperty("source_flow_type")]
        public string SourceFlowType { get; set; }
    }
}
