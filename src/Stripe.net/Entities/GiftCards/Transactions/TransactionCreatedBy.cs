// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class TransactionCreatedBy : StripeEntity<TransactionCreatedBy>
    {
        [JsonProperty("checkout")]
        public TransactionCreatedByCheckout Checkout { get; set; }

        [JsonProperty("order")]
        public TransactionCreatedByOrder Order { get; set; }

        [JsonProperty("payment")]
        public TransactionCreatedByPayment Payment { get; set; }

        /// <summary>
        /// The type of event that created this object.
        /// One of: <c>checkout</c>, <c>order</c>, or <c>payment</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
