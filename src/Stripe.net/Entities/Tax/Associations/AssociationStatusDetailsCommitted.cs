// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AssociationStatusDetailsCommitted : StripeEntity<AssociationStatusDetailsCommitted>
    {
        /// <summary>
        /// Attempts to create Tax Transaction reversals.
        /// </summary>
        [JsonProperty("reversals")]
        public List<AssociationStatusDetailsCommittedReversal> Reversals { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax/transaction/object">Tax Transaction</a>.
        /// </summary>
        [JsonProperty("transaction")]
        public string Transaction { get; set; }
    }
}
