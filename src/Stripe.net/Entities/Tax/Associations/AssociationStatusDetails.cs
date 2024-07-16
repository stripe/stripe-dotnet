// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationStatusDetails : StripeEntity<AssociationStatusDetails>
    {
        [JsonProperty("committed")]
        public AssociationStatusDetailsCommitted Committed { get; set; }

        [JsonProperty("errored")]
        public AssociationStatusDetailsErrored Errored { get; set; }
    }
}
