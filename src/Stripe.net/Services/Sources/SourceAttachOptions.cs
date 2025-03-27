namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceAttachOptions : BaseOptions
    {
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public string Source { get; set; }

        [JsonProperty("validate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("validate")]
#endif
        public bool? Validate { get; set; }
    }
}
