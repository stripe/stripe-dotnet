// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionReversal : StripeEntity<TransactionReversal>
    {
        /// <summary>
        /// The <c>id</c> of the reversed <c>Transaction</c> object.
        /// </summary>
        [JsonProperty("original_transaction")]
        [STJS.JsonPropertyName("original_transaction")]
        public string OriginalTransaction { get; set; }
    }
}
