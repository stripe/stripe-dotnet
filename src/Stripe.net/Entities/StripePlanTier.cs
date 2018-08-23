namespace Stripe
{
    using Newtonsoft.Json;

    public class StripePlanTier
    {
        [JsonProperty("unit_amount")]
        public int UnitAmount { get; set; }

        [JsonProperty("up_to")]
        public int? UpTo { get; set; }
    }
}