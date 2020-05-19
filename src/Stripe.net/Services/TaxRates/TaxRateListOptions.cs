namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TaxRateListOptions : ListOptionsWithCreated
    {
        [JsonProperty("active")]
        public bool? Active { get; set; }

        [JsonProperty("inclusive")]
        public bool? Inclusive { get; set; }
    }
}
