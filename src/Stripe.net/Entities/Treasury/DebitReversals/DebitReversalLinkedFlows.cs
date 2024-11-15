// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DebitReversalLinkedFlows : StripeEntity<DebitReversalLinkedFlows>
    {
        /// <summary>
        /// Set if there is an Issuing dispute associated with the DebitReversal.
        /// </summary>
        [JsonProperty("issuing_dispute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_dispute")]
#endif

        public string IssuingDispute { get; set; }
    }
}
