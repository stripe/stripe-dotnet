namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class LocationUpdateOptions : LocationSharedOptions
    {
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
