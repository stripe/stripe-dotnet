namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SourceVerifyOptions : BaseOptions
    {
        [JsonProperty("values")]
        public List<string> Values { get; set; }
    }
}
