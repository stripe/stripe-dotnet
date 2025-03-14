// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AssociationStatusDetailsCommittedReversal : StripeEntity<AssociationStatusDetailsCommittedReversal>
    {
        /// <summary>
        /// Status of the attempted Tax Transaction reversal.
        /// One of: <c>committed</c>, or <c>errored</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        [JsonProperty("status_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status_details")]
#endif
        public AssociationStatusDetailsCommittedReversalStatusDetails StatusDetails { get; set; }
    }
}
