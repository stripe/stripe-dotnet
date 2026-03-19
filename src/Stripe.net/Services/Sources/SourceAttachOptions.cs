namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class SourceAttachOptions : BaseOptions
    {
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonProperty("validate")]
        [STJS.JsonPropertyName("validate")]
        public bool? Validate { get; set; }
    }
}
