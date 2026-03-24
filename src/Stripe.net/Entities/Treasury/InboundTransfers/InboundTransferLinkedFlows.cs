// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferLinkedFlows : StripeEntity<InboundTransferLinkedFlows>
    {
        /// <summary>
        /// If funds for this flow were returned after the flow went to the <c>succeeded</c> state,
        /// this field contains a reference to the ReceivedDebit return.
        /// </summary>
        [JsonProperty("received_debit")]
        [STJS.JsonPropertyName("received_debit")]
        public string ReceivedDebit { get; set; }
    }
}
