// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class CardCreatedBy : StripeEntity<CardCreatedBy>
    {
        [JsonProperty("checkout")]
        public CardCreatedByCheckout Checkout { get; set; }

        [JsonProperty("order")]
        public CardCreatedByOrder Order { get; set; }

        [JsonProperty("payment")]
        public CardCreatedByPayment Payment { get; set; }

        /// <summary>
        /// The type of event that created this object.
        /// One of: <c>checkout</c>, <c>order</c>, or <c>payment</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
