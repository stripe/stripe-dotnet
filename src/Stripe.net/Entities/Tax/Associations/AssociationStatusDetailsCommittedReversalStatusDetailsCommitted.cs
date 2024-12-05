// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationStatusDetailsCommittedReversalStatusDetailsCommitted : StripeEntity<AssociationStatusDetailsCommittedReversalStatusDetailsCommitted>
    {
        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax/transaction/object">Tax Transaction</a>.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
