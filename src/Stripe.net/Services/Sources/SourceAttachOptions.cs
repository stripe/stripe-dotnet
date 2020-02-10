namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SourceAttachOptions : BaseOptions
    {
        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("validate")]
        public bool? Validate { get; set; }
    }
}
