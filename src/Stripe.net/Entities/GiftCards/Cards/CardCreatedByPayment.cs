// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class CardCreatedByPayment : StripeEntity<CardCreatedByPayment>
    {
        /// <summary>
        /// The PaymentIntent that created this object.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
