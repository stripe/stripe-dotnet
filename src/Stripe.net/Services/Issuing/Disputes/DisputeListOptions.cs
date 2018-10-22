namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeListOptions : ListOptionsWithCreated
    {
        [JsonProperty("transaction")]
        public string TransactionId { get; set; }
    }
}
