// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class DebitReversalLinkedFlows : StripeEntity<DebitReversalLinkedFlows>
    {
        /// <summary>
        /// Set if there is an Issuing dispute associated with the DebitReversal.
        /// </summary>
        [JsonProperty("issuing_dispute")]
        public string IssuingDispute { get; set; }
    }
}
