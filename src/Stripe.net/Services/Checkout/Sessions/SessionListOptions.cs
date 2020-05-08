namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionListOptions : ListOptionsWithCreated
    {
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        [JsonProperty("subscription")]
        public string Subscription { get; set; }
    }
}
