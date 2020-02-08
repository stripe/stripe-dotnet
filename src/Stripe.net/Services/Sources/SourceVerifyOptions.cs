namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SourceVerifyOptions : BaseOptions
    {
        [JsonProperty("values")]
        public List<string> Values { get; set; }
    }
}
