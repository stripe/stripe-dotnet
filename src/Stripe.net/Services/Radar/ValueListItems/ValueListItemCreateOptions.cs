// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ValueListItemCreateOptions : BaseOptions
    {
        /// <summary>
        /// The value of the item (whose type must match the type of the parent value list).
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public string Value { get; set; }

        /// <summary>
        /// The identifier of the value list which the created item will be added to.
        /// </summary>
        [JsonProperty("value_list")]
        [STJS.JsonPropertyName("value_list")]
        public string ValueList { get; set; }
    }
}
