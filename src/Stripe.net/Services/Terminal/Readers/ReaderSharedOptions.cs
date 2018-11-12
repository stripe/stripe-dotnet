namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderSharedOptions : BaseOptions
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
