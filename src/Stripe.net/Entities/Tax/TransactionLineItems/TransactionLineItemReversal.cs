// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class TransactionLineItemReversal : StripeEntity<TransactionLineItemReversal>
    {
        /// <summary>
        /// The <c>id</c> of the line item to reverse in the original transaction.
        /// </summary>
        [JsonProperty("original_line_item")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("original_line_item")]
#endif
        public string OriginalLineItem { get; set; }
    }
}
