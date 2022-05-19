// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class InboundTransferLinkedFlows : StripeEntity<InboundTransferLinkedFlows>
    {
        /// <summary>
        /// If funds for this flow were returned after the flow went to the <c>succeeded</c> state,
        /// this field contains a reference to the ReceivedDebit return.
        /// </summary>
        [JsonProperty("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
