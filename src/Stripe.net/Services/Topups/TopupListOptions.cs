namespace Stripe
{
    using Newtonsoft.Json;

    public class TopupListOptions : ListOptions
    {
        [JsonProperty("created")]
        public DateFilter Created { get; set; }
    }
}
