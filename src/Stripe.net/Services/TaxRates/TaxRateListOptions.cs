namespace Stripe
{
    using Newtonsoft.Json;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
