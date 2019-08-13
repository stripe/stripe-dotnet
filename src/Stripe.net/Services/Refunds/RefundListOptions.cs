namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
