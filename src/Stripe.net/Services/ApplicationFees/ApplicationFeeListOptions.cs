namespace Stripe
{
    using Newtonsoft.Json;

    public class ApplicationFeeListOptions : ListOptions
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }
    }
}