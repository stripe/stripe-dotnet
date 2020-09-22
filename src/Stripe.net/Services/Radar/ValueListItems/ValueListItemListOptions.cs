// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListItemListOptions : ListOptionsWithCreated
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
