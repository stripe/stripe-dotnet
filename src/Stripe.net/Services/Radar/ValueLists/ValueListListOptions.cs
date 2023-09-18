// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class ValueListListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// The alias used to reference the value list when writing rules.
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// A value contained within a value list - returns all value lists containing this value.
        /// </summary>
        [JsonProperty("contains")]
        public string Contains { get; set; }
    }
}
