// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class TransactionReversal : StripeEntity<TransactionReversal>
    {
        /// <summary>
        /// The <c>id</c> of the reversed <c>Transaction</c> object.
        /// </summary>
        [JsonProperty("original_transaction")]
        public string OriginalTransaction { get; set; }
    }
}
