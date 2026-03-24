// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AssociationTaxTransactionAttemptCommitted : StripeEntity<AssociationTaxTransactionAttemptCommitted>
    {
        /// <summary>
        /// The <a href="https://docs.stripe.com/api/tax/transaction/object">Tax Transaction</a>.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
