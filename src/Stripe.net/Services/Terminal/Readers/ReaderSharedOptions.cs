namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderSharedOptions : BaseOptions
    {
        [JsonProperty("label")]
        public string Label { get; set; }

        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
