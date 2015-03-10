using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeBankAccountVerifyOptions
    {
        [JsonProperty("amounts[]")]
        public int Amount1 { get; set; }

        [JsonProperty("amounts[]")]
        public int Amount2 { get; set; }
    }
}
