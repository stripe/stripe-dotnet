// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxTransactionReversal : StripeEntity<TaxTransactionReversal>
    {
        /// <summary>
        /// The <c>id</c> of the <c>Transaction</c> object that this one reversed.
        /// </summary>
        [JsonProperty("original_transaction")]
        public string OriginalTransaction { get; set; }
    }
}
