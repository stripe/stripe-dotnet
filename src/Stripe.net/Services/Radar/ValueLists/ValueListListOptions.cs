namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ValueListListOptions : ListOptionsWithCreated
    {
        [JsonProperty("alias")]
        public string Alias { get; set; }

        [JsonProperty("contains")]
        public string Contains { get; set; }
    }
}
