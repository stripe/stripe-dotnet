// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class TransactionCreatedByCheckout : StripeEntity<TransactionCreatedByCheckout>
    {
        /// <summary>
        /// The Stripe CheckoutSession that created this object.
        /// </summary>
        [JsonProperty("checkout_session")]
        public string CheckoutSession { get; set; }

        /// <summary>
        /// The Stripe CheckoutSession LineItem that created this object.
        /// </summary>
        [JsonProperty("line_item")]
        public string LineItem { get; set; }
    }
}
