namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTier : StripeEntity
    {
        [JsonProperty("unit_amount")]
        public long UnitAmount { get; set; }

        [JsonProperty("up_to")]
        public long? UpTo { get; set; }
    }
}
