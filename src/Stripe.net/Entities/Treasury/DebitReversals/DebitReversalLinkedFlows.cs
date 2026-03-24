// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DebitReversalLinkedFlows : StripeEntity<DebitReversalLinkedFlows>
    {
        /// <summary>
        /// Set if there is an Issuing dispute associated with the DebitReversal.
        /// </summary>
        [JsonProperty("issuing_dispute")]
        [STJS.JsonPropertyName("issuing_dispute")]
        public string IssuingDispute { get; set; }
    }
}
