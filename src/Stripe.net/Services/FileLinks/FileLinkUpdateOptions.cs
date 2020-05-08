namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLinkUpdateOptions : BaseOptions, IHasMetadata
    {
        [JsonProperty("expires_at")]
        public AnyOf<DateTime?, string, string> ExpiresAt { get; set; }

        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
