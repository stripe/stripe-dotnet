namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class LocationListOptions : ListOptions
    {
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
