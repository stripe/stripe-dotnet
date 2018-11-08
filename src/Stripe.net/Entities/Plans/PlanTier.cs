namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTier : StripeEntity
    {
        [JsonProperty("flat_amount")]
        public long? FlatAmount { get; set; }

        [JsonProperty("unit_amount")]
        public long? UnitAmount { get; set; }

        [JsonProperty("up_to")]
        public long? UpTo { get; set; }
    }
}
