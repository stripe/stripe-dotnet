// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AssociationStatusDetailsCommittedReversalStatusDetails : StripeEntity<AssociationStatusDetailsCommittedReversalStatusDetails>
    {
        [JsonProperty("committed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("committed")]
#endif
        public AssociationStatusDetailsCommittedReversalStatusDetailsCommitted Committed { get; set; }

        [JsonProperty("errored")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("errored")]
#endif
        public AssociationStatusDetailsCommittedReversalStatusDetailsErrored Errored { get; set; }
    }
}
