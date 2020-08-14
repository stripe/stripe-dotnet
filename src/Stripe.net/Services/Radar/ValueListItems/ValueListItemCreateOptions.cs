namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListItemCreateOptions : BaseOptions
    {
        /// <summary>
        /// The value of the item (whose type must match the type of the parent value list).
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }

        /// <summary>
        /// The identifier of the value list which the created item will be added to.
        /// </summary>
        [JsonProperty("value_list")]
        public string ValueList { get; set; }
    }
}
