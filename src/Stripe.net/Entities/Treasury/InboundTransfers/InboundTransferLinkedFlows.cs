// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InboundTransferLinkedFlows : StripeEntity<InboundTransferLinkedFlows>
    {
        /// <summary>
        /// If funds for this flow were returned after the flow went to the <c>succeeded</c> state,
        /// this field contains a reference to the ReceivedDebit return.
        /// </summary>
        [JsonProperty("received_debit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("received_debit")]
#endif
        public string ReceivedDebit { get; set; }
    }
}
