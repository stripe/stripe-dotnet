namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class DisputeCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
