using System;
using System.Collections.Generic;
using Newtonsoft.Json;

using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeManagedAccountCreateOptions
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
