namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ValueListCreateOptions : ValueListSharedOptions
    {
        [JsonProperty("item_type")]
        public string ItemType { get; set; }
    }
}
