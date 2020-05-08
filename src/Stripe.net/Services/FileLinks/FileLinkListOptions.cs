namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileLinkListOptions : ListOptionsWithCreated
    {
        [JsonProperty("expired")]
        public bool? Expired { get; set; }

        [JsonProperty("file")]
        public string File { get; set; }
    }
}
