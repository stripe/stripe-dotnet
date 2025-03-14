// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AssociationStatusDetailsCommitted : StripeEntity<AssociationStatusDetailsCommitted>
    {
        /// <summary>
        /// Attempts to create Tax Transaction reversals.
        /// </summary>
        [JsonProperty("reversals")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reversals")]
#endif
        public List<AssociationStatusDetailsCommittedReversal> Reversals { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax/transaction/object">Tax Transaction</a>.
        /// </summary>
        [JsonProperty("transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction")]
#endif
        public string Transaction { get; set; }
    }
}
