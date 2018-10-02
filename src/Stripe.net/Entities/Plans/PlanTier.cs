namespace Stripe
{
    using Newtonsoft.Json;

    public class PlanTier : StripeEntity
    {
        [JsonProperty("unit_amount")]
        public int UnitAmount { get; set; }

        [JsonProperty("up_to")]
        public int? UpTo { get; set; }
    }
}
