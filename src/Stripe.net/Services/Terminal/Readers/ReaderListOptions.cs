namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderListOptions : ListOptions
    {
        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
