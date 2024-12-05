// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationStatusDetailsCommittedReversalStatusDetails : StripeEntity<AssociationStatusDetailsCommittedReversalStatusDetails>
    {
        [JsonProperty("committed")]
        public AssociationStatusDetailsCommittedReversalStatusDetailsCommitted Committed { get; set; }

        [JsonProperty("errored")]
        public AssociationStatusDetailsCommittedReversalStatusDetailsErrored Errored { get; set; }
    }
}
