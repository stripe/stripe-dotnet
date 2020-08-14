namespace Stripe
{
    using Newtonsoft.Json;

    public class Dob : StripeEntity<Dob>
    {
        [JsonProperty("day")]
        public long? Day { get; set; }

        [JsonProperty("month")]
        public long? Month { get; set; }

        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
