// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationStatusDetailsCommittedReversal : StripeEntity<AssociationStatusDetailsCommittedReversal>
    {
        /// <summary>
        /// Status of the attempted Tax Transaction reversal.
        /// One of: <c>committed</c>, or <c>errored</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("status_details")]
        public AssociationStatusDetailsCommittedReversalStatusDetails StatusDetails { get; set; }
    }
}
