namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderUpdateOptions : ReaderSharedOptions
    {
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
