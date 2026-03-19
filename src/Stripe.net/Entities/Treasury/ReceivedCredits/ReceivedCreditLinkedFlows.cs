// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditLinkedFlows : StripeEntity<ReceivedCreditLinkedFlows>
    {
        /// <summary>
        /// The CreditReversal created as a result of this ReceivedCredit being reversed.
        /// </summary>
        [JsonProperty("credit_reversal")]
        [STJS.JsonPropertyName("credit_reversal")]
        public string CreditReversal { get; set; }

        /// <summary>
        /// Set if the ReceivedCredit was created due to an <a
        /// href="https://api.stripe.com#issuing_authorizations">Issuing Authorization</a> object.
        /// </summary>
        [JsonProperty("issuing_authorization")]
        [STJS.JsonPropertyName("issuing_authorization")]
        public string IssuingAuthorization { get; set; }

        /// <summary>
        /// Set if the ReceivedCredit is also viewable as an <a
        /// href="https://api.stripe.com#issuing_transactions">Issuing transaction</a> object.
        /// </summary>
        [JsonProperty("issuing_transaction")]
        [STJS.JsonPropertyName("issuing_transaction")]
        public string IssuingTransaction { get; set; }

        /// <summary>
        /// ID of the source flow. Set if <c>network</c> is <c>stripe</c> and the source flow is
        /// visible to the user. Examples of source flows include OutboundPayments, payouts, or
        /// CreditReversals.
        /// </summary>
        [JsonProperty("source_flow")]
        [STJS.JsonPropertyName("source_flow")]
        public string SourceFlow { get; set; }

        /// <summary>
        /// The expandable object of the source flow.
        /// </summary>
        [JsonProperty("source_flow_details")]
        [STJS.JsonPropertyName("source_flow_details")]
        public ReceivedCreditLinkedFlowsSourceFlowDetails SourceFlowDetails { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit (for example,
        /// <c>outbound_payment</c>).
        /// </summary>
        [JsonProperty("source_flow_type")]
        [STJS.JsonPropertyName("source_flow_type")]
        public string SourceFlowType { get; set; }
    }
}
