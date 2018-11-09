namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundListOptions : ListOptionsWithCreated
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }
    }
}
