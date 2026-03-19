// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class TransactionLineItemReversal : StripeEntity<TransactionLineItemReversal>
    {
        /// <summary>
        /// The <c>id</c> of the line item to reverse in the original transaction.
        /// </summary>
        [JsonProperty("original_line_item")]
        [STJS.JsonPropertyName("original_line_item")]
        public string OriginalLineItem { get; set; }
    }
}
