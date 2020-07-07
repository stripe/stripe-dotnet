namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionListOptions : ListOptions
    {
        /// <summary>
        /// Only return the Checkout Session for the PaymentIntent specified.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the Subscription specified.
        /// </summary>
        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
