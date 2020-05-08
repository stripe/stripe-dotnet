namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ValueListItemCreateOptions : BaseOptions
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
