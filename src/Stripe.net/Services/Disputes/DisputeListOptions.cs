namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }

        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
