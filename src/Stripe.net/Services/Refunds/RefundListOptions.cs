namespace Stripe
{
    using Newtonsoft.Json;

    public class RefundListOptions : ListOptions
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }
    }
}