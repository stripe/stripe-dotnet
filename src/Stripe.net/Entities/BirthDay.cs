namespace Stripe
{
    using Newtonsoft.Json;

    public class BirthDay : StripeEntity
    {
        [JsonProperty("day")]
        public int? Day { get; set; }

        [JsonProperty("month")]
        public int? Month { get; set; }

        [JsonProperty("year")]
        public int? Year { get; set; }
    }
}
