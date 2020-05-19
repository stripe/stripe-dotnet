namespace Stripe
{
    using Newtonsoft.Json;
    using System;
    using Stripe.Infrastructure;

    public class FileLinkCreateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
