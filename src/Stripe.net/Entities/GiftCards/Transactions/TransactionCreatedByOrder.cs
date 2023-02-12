// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class TransactionCreatedByOrder : StripeEntity<TransactionCreatedByOrder>
    {
        /// <summary>
        /// The Stripe Order LineItem that created this object.
        /// </summary>
        [JsonProperty("line_item")]
        public string LineItem { get; set; }

        /// <summary>
        /// The Stripe Order that created this object.
        /// </summary>
        [JsonProperty("order")]
        public string Order { get; set; }
    }
}
