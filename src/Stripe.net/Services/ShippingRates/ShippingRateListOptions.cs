// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ShippingRateListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return shipping rates that are active or inactive.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return shipping rates for the given currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
