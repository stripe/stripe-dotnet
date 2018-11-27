namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ValueListItemCreateOptions : BaseOptions
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("value_list")]
        public string ValueListId { get; set; }
    }
}
