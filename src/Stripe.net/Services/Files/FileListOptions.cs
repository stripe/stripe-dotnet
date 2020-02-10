namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class FileListOptions : ListOptionsWithCreated
    {
        [JsonProperty("purpose")]
        public string Purpose { get; set; }
    }
}
