namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListItemCreateOptions : BaseOptions
    {
        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
