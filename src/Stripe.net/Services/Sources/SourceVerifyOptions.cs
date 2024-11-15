// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceVerifyOptions : BaseOptions
    {
        /// <summary>
        /// The values needed to verify the source.
        /// </summary>
        [JsonProperty("values")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("values")]
#endif

        public List<string> Values { get; set; }
    }
}
