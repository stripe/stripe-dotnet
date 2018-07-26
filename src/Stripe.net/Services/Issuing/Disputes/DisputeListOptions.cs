namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeListOptions : StripeListOptions
    {
        [JsonProperty("created")]
        public StripeDateFilter Created { get; set; }

        [JsonProperty("transaction")]
        public string TransactionId { get; set; }
    }
}
