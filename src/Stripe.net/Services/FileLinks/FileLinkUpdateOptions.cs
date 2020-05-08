namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLinkUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
