namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class ReaderSharedOptions : BaseOptions
    {
        [JsonProperty("label")]
        public string Label { get; set; }
    }
}
