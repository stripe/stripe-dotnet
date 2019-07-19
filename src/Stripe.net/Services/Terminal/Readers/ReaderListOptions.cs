namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class ReaderListOptions : ListOptions
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
