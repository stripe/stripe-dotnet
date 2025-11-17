// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AssociationTaxTransactionAttemptCommitted : StripeEntity<AssociationTaxTransactionAttemptCommitted>
    {
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
