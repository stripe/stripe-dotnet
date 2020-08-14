namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SourceVerifyOptions : BaseOptions
    {
        /// <summary>
        /// The values needed to verify the source.
        /// </summary>
        [JsonProperty("values")]
        public List<string> Values { get; set; }
    }
}
