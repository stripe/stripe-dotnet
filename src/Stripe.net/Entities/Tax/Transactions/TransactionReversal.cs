// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionReversal : StripeEntity<TransactionReversal>
    {
        /// <summary>
        /// The <c>id</c> of the reversed <c>Transaction</c> object.
        /// </summary>
        [JsonProperty("original_transaction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_transaction")]
#endif
        public string OriginalTransaction { get; set; }
    }
}
